using QLTimKiemSv.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTimKiemSv
{
    public partial class Form1 : Form
    {
        QLSV ql;
        public Form1()
        {
            ql = new QLSV();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var svs = ql.GetAllIdSv();
            comboBox1.Items.AddRange(svs.Cast<object>().ToArray());

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedItem = (int)comboBox1.SelectedItem;
                var sv = ql.GetSvienById(selectedItem);
                textBox1.Text = sv.TEN.Split(' ')[0];
                textBox2.Text = sv.TEN.ToString().Replace(sv.TEN.Split(' ')[0], "").Trim();
                textBox3.Text = DateTime.Parse(sv.NAMSINH.ToString()).ToString("dd/MM/yyyy");

                textBox4.Text = (bool)sv.GIOITINH ? "Nam" : "Nữ";
                textBox5.Text = sv.KHOA?.MAKHOA;

                BindingSource binding = new BindingSource();
                var lst = new List<StudentKQ>();
                foreach (var item in sv.KQUAs.Select(x => x.HPHAN))
                {
                    var stukq = new StudentKQ()
                    {
                        TenMh = item.MHOC.TENMH,
                        DiemThi = (double)item.KQUAs.Where(x => x.HPHAN.MAMH == item.MAMH).FirstOrDefault().DIEM,
                        MaMh = item.MAMH

                    };
                    lst.Add(stukq);
                }
                
                binding.DataSource = lst;

                //bind datagridview to binding source
                dataGridView1.DataSource = binding;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
