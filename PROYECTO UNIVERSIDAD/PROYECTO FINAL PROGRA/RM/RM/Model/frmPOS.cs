using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RM.Model
{
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
        }


        public int MainID = 0;
        public string OrderType;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.BorderStyle = BorderStyle.FixedSingle;
            AddCategory();

            ProductPanel.Controls.Clear();
            LoadProducts();
        }

        private void AddCategory()
        {
            string qry = "Select * from Category";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            CategoryPanel.Controls.Clear();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Guna2Button b = new Guna2Button();
                    b.FillColor = Color.FromArgb(50, 55, 89);
                    b.Size = new Size(156, 45);
                    b.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                    b.Text = row["catName"].ToString();
                    b.CheckedState.FillColor = Color.FromArgb(241, 85, 126);

                    b.Click += new EventHandler(_Click);

                    CategoryPanel.Controls.Add(b);
                }
            }
        }

        private void _Click(object? sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button b = (Guna.UI2.WinForms.Guna2Button)sender;
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PCategory.ToLower().Contains(b.Text.Trim().ToLower());
            }
        }

        private void AddItems(string id, String proID, string name, string cat, string price, Image pimage)
        {
            var w = new ucProduct()
            {
                PName = name,
                PPrice = Convert.ToInt32(price),
                PCategory = cat,
                PImage = pimage,
                id = Convert.ToInt32(proID)
            };

            ProductPanel.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;
                bool found = false;
                foreach (DataGridViewRow item in guna2DataGridView2.Rows)
                {
                    if (Convert.ToInt32(item.Cells["dataGridViewTextBoxColumn2"].Value) == wdg.id)
                    {
                        item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;
                        item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) *
                                                        double.Parse(item.Cells["dgvPrice"].Value.ToString());
                        return;
                    }
                }

                guna2DataGridView2.Rows.Add(new object[] { 0, 0, wdg.id, wdg.PName, 1, wdg.PPrice, wdg.PPrice });
                GetTotal();
            };
        }

        private void LoadProducts()
        {
            string qry = "Select * from products inner join category on catID = CategoryID";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Byte[] imagearray = (byte[])item["pImage"];
                using (MemoryStream ms = new MemoryStream(imagearray))
                {
                    AddItems("0", item["pID"].ToString(), item["pName"].ToString(), item["catName"].ToString(),
                            item["pPrice"].ToString(), Image.FromStream(ms));
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in ProductPanel.Controls)
            {
                if (item is ucProduct pro)
                {
                    pro.Visible = pro.PName.ToLower().Contains(txtSearch.Text.Trim().ToLower());
                }
            }
        }

        private void Guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void GetTotal()
        {
            double total = 0;
            lblTotal.Text = "";
            foreach (DataGridViewRow item in guna2DataGridView2.Rows)
            {
                total += double.Parse(item.Cells["dgvAmount"].Value.ToString());
            }

            lblTotal.Text = total.ToString("N2");
        }




        private void btnNew_Click(object sender, EventArgs e)
        {
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            guna2DataGridView2.Rows.Clear();
            MainID = 0;
            lblTotal.Text = "00";
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            OrderType = "Delivery";
        }

        private void btnDin_Click(object sender, EventArgs e)
        {

            OrderType = "Din In";
            frmTableSelect frm = new frmTableSelect();
            MainClass.BlurBackground(frm);
            if (frm.TableName != "")
            {
                lblWaiter.Text = frm.TableName;
                lblTable.Visible = true;
            }
            else
            {
                lblTable.Text = "";
                lblTable.Visible = false;
            }

            frmWaiterSelect frm2 = new frmWaiterSelect();
            MainClass.BlurBackground(frm2);
            if (frm2.waiterName != "")
            {
                lblWaiter.Text = frm2.waiterName;
                lblTable.Visible = true;
            }
            else
            {
                lblTable.Text = "";
                lblTable.Visible = false;
            }

        }

        private void btnKot_Click(object sender, EventArgs e)
        {
            string qry1 = ""; // Main table
            string qry2 = ""; // Detail table

            int detailID = 0;

            if (MainID == 0) // Insert
            {
                qry1 = @"Insert into tblMain (aDate, aTime, TableName, WaiterName, status, orderType, total, received, change)
                Values (@aDate, @aTime, @TableName, @WaiterName, @status, @orderType, @total, @received, @change);
                Select SCOPE_IDENTITY()";
            }
            else // Update
            {
                qry1 = @"Update tblMain Set status = @status, total = @total, received = @received, change = @change 
                where MainID = @ID";
            }

            Hashtable ht = new Hashtable();

            SqlCommand cmd = new SqlCommand(qry1, MainClass.con);
            cmd.Parameters.AddWithValue("@ID", MainID);
            cmd.Parameters.AddWithValue("@aDate", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@TableName", lblTable.Text);
            cmd.Parameters.AddWithValue("@WaiterName", lblWaiter.Text);
            cmd.Parameters.AddWithValue("@status", "Pending");
            cmd.Parameters.AddWithValue("@orderType", OrderType);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lblTotal.Text));
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));

            if (MainClass.con.State == ConnectionState.Closed)
            {
                MainClass.con.Open();
            }

            if (MainID == 0)
            {
                MainID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            else
            {
                cmd.ExecuteNonQuery();
            }

            foreach (DataGridViewRow row in guna2DataGridView2.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dataGridViewTextBoxColumn2"].Value);

                if (detailID == 0)// Insert
                {
                    qry2 = @"Insert into tblDetails (MainID, proID, qty, price, amount) 
                    Values (@MainID, @proID, @qty, @price, @amount)";
                }
                else// Update
                {
                    qry2 = @"Update tblDetails Set proID = @proID, qty = @qty, price = @price, amount = @amount 
                    where DetailID = @ID";
                }

                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                cmd2.Parameters.AddWithValue("@ID", detailID);
                cmd2.Parameters.AddWithValue("@MainID", MainID);
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["dvgproID"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));

                cmd2.ExecuteNonQuery();
            }

            if (MainClass.con.State == ConnectionState.Open)
            {
                MainClass.con.Close();
            }

            guna2MessageDialog1.Show("Saved Successfully");
            MainID = 0;
            detailID = 0;
            guna2DataGridView1.Rows.Clear();
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            lblTotal.Text = "00";
            {
            }

        }
        public int id = 0;
        private object amount;

        private void btnBill_Click(object sender, EventArgs e)
        {
            frmBillList frm = new frmBillList();
            MainClass.BlurBackground(frm);

            if (frm.MainID > 0)
            {
                id = frm.MainID;
                loadEntries();
            }
        }



        private void loadEntries()
        {
            string qry = @"Select * from tblMain m
                          inner join tblDetails d on m.MainID = d.MainID
                          inner join products p on p.pID = d.proID
                          where m.MainID = @MainID";

            SqlCommand cmd2 = new SqlCommand(qry, MainClass.con);
            cmd2.Parameters.AddWithValue("@MainID", id);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);

            if (dt2.Rows.Count > 0)
            {
                var firstRow = dt2.Rows[0];

                // Determina el tipo de orden y actualiza los controles correspondientes
                string orderType = firstRow["orderType"].ToString();
                if (orderType == "Delivery")
                {
                    btnDelivery.Checked = true;
                    lblWaiter.Visible = false;
                    lblTable.Visible = false;
                }
                else if (orderType == "Take away")
                {
                    btnTake.Checked = true;
                    lblWaiter.Visible = false;
                    lblTable.Visible = false;
                }
                else
                {
                    btnDin.Checked = true;
                    lblWaiter.Visible = true;
                    lblTable.Visible = true;
                }

                guna2DataGridView2.Rows.Clear();

                // Llena el DataGridView con los detalles de la factura
                foreach (DataRow item in dt2.Rows)
                {
                    lblTable.Text = item["TableName"].ToString();
                    lblWaiter.Text = item["WaiterName"].ToString();

                    string detailid = item["DetailID"].ToString();
                    string proName = item["pName"].ToString();
                    string proid = item["proID"].ToString();
                    string qty = item["qty"].ToString();
                    string price = item["price"].ToString();
                    string amount = item["amount"].ToString();

                    object[] obj = { 0, detailid, proid, proName, qty, price, amount };
                    guna2DataGridView2.Rows.Add(obj);
                }

                GetTotal(); // Calcula y actualiza el total
            }

        }

        private void btncheckout_Click(object sender, EventArgs e)
        {
            frmCheckout frm = new frmCheckout();
            frm.MainID = id;
            frm.amt = Convert.ToDouble(lblTotal.Text);
            MainClass.BlurBackground(frm);

            MainID = 0;
            guna2DataGridView1.Rows.Clear();
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            lblTotal.Text = "00";
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            OrderType = "Take Away";
        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            string qry1 = ""; // Main table
            string qry2 = ""; // Detail table

            int detailID = 0;

            if (MainID == 0) // Insert
            {
                qry1 = @"Insert into tblMain (aDate, aTime, TableName, WaiterName, status, orderType, total, received, change)
                Values (@aDate, @aTime, @TableName, @WaiterName, @status, @orderType, @total, @received, @change);
                Select SCOPE_IDENTITY()";
            }
            else // Update
            {
                qry1 = @"Update tblMain Set status = @status, total = @total, received = @received, change = @change 
                where MainID = @ID";
            }

            Hashtable ht = new Hashtable();

            SqlCommand cmd = new SqlCommand(qry1, MainClass.con);
            cmd.Parameters.AddWithValue("@ID", MainID);
            cmd.Parameters.AddWithValue("@aDate", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@TableName", lblTable.Text);
            cmd.Parameters.AddWithValue("@WaiterName", lblWaiter.Text);
            cmd.Parameters.AddWithValue("@status", "Hold");
            cmd.Parameters.AddWithValue("@orderType", OrderType);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lblTotal.Text));
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));

            if (MainClass.con.State == ConnectionState.Closed)
            {
                MainClass.con.Open();
            }

            if (MainID == 0)
            {
                MainID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            else
            {
                cmd.ExecuteNonQuery();
            }

            foreach (DataGridViewRow row in guna2DataGridView2.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dataGridViewTextBoxColumn2"].Value);

                if (detailID == 0)// Insert
                {
                    qry2 = @"Insert into tblDetails (MainID, proID, qty, price, amount) 
                    Values (@MainID, @proID, @qty, @price, @amount)";
                }
                else// Update
                {
                    qry2 = @"Update tblDetails Set proID = @proID, qty = @qty, price = @price, amount = @amount 
                    where DetailID = @ID";
                }

                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                cmd2.Parameters.AddWithValue("@ID", detailID);
                cmd2.Parameters.AddWithValue("@MainID", MainID);
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["dvgproID"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));

                cmd2.ExecuteNonQuery();
            }

            if (MainClass.con.State == ConnectionState.Open)
            {
                MainClass.con.Close();
            }

            guna2MessageDialog1.Show("Saved Successfully");
            MainID = 0;
            detailID = 0;
            guna2DataGridView1.Rows.Clear();
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            lblTotal.Text = "00";
            {
            }
        }
    }
}
