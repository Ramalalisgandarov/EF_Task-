using Microsoft.EntityFrameworkCore;
using System;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public static int cur_id;
        public Form1()
        {
            InitializeComponent();

            dgv.SelectionChanged += dgv_SelectionChanged;

        }

        private void name_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void desc_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void cat_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Name = name_tb.Text,
                Description = desc_tb.Text,
                Category = cat_tb.Text
            };

            using (appDbContext db = new appDbContext())
            {
                db.Product.Add(product);
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}\nInner Exception: {ex.InnerException?.Message}");
                }
            }

            LoadData();
            ClearTbs(new TextBox[] { name_tb, desc_tb, cat_tb });
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (cur_id > -1)
            {
                using (appDbContext db = new appDbContext())
                {
                    Product product = db.Product.Find(cur_id); 
                    if (product != null)
                    {
                        db.Product.Remove(product); 
                        db.SaveChanges(); 
                    }
                }
                LoadData();
                ClearTbs(new TextBox[] { name_tb, desc_tb, cat_tb });
                cur_id = -1; 
            }
            else
            {
                MessageBox.Show("Please select a record to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {

            if (cur_id > -1)
            {
                using (appDbContext db = new appDbContext())
                {
                    Product product = db.Product.Find(cur_id); 
                    if (product != null)
                    {
                        db.Product.Remove(product); 
                        db.SaveChanges(); 
                    }
                }

                LoadData();
                ClearTbs(new TextBox[] { name_tb, desc_tb, cat_tb });
                cur_id = -1; 
            }
            else
            {
                MessageBox.Show("Please select a record to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (cur_id > -1)
            {
                using (appDbContext db = new appDbContext())
                {
                    Product product = db.Product.Find(cur_id);

                    if (product != null)
                    {
                        product.Name = name_tb.Text;
                        product.Description = desc_tb.Text;
                        product.Category = cat_tb.Text;

                        db.Product.Update(product);
                        db.SaveChanges();
                    }
                }

                LoadData();
                ClearTbs(new TextBox[] { name_tb, desc_tb, cat_tb });
            }
            else
            {
                MessageBox.Show("Please select a record to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void clear_btn_Click_1(object sender, EventArgs e)
        {
            ClearTbs(new TextBox[] { name_tb, desc_tb, cat_tb });
            cur_id = -1;
        }

        private void LoadData()
        {
            using (appDbContext db = new appDbContext())
            {
                dgv.DataSource = db.Product.ToList();
            }
        }

        private void ClearTbs(TextBox[] tbs)
        {
            foreach (TextBox t in tbs)
            {
                t.Text = string.Empty;
            }
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                cur_id = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value); 
                using (appDbContext db = new appDbContext())
                {
                    Product product = db.Product.Find(cur_id); 
                    if (product != null)
                    {
                        name_tb.Text = product.Name;
                        desc_tb.Text = product.Description;
                        cat_tb.Text = product.Category;
                    }
                }
            }
            else
            {
                cur_id = -1;
            }
        }


    }
}
