using BUS;
using DAL.Entities;
using Guna.UI2.AnimatorNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmThemVatLieu : Form
    {
        private readonly Storage_Service vatLieu_Service = new Storage_Service();
        public frmThemVatLieu()
        {
            InitializeComponent();
        }

        private void gnbtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gnbtnThem_Click(object sender, EventArgs e)
        {
            /*try
            {
                List<ToolAndMaterial> tol = new List<ToolAndMaterial>();
                tol = vatLieu_Service.GetAll();
                foreach(var t in tol)
                {
                    if(Convert.ToInt32(gntxtMa.Text) == t.TaM_ID)
                    {
                        throw new Exception("ID đã tồn tại!");
                    }
                }
                var item = new ToolAndMaterial()
                {
                    TaM_ID = Convert.ToInt32(gntxtMa.Text),
                    Content = gntxtTen.Text,
                    Unit = gntxtDVT.Text,
                    UnitPrice = (int?)Convert.ToInt64(gntxtGia.Text)
                };
                vatLieu_Service.AddTool(item);
                
                MessageBox.Show("Thêm mới dữ liệu thành công", "Thông báo", MessageBoxButtons.OK);
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }           */
        }

        private void gnbtnSua_Click(object sender, EventArgs e)
        {
           /* List<ToolAndMaterial> tol = new List<ToolAndMaterial>();
            tol = vatLieu_Service.GetAll();
            int flag = -1;
            foreach (var t in tol)
            {
                if (Convert.ToInt32(gntxtMa.Text) == t.TaM_ID)
                {
                    var item = new ToolAndMaterial()
                    {
                        TaM_ID = Convert.ToInt32(gntxtMa.Text),
                        Content = gntxtTen.Text,
                        Unit = gntxtDVT.Text,
                        UnitPrice = (int?)Convert.ToInt64(gntxtGia.Text)
                    };
                    vatLieu_Service.addOrUpdateTol(item);
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK);
                    flag = 1;
                    break;
                }
            }

            if(flag == -1)
            {
                MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK);
            }*/
        }

        private void gnbtnXoa_Click(object sender, EventArgs e)
        {
            /*var context = new NhaKhoaDB();
            try
            {
                int id = Convert.ToInt32(gntxtMa.Text);
                ToolAndMaterial dbDelete = context.ToolAndMaterials.FirstOrDefault(p => p.TaM_ID == id);
                if (dbDelete != null)
                {
                    DialogResult d = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    { 
                        context.ToolAndMaterials.Remove(dbDelete);
                        context.SaveChanges();
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                    throw new Exception("Lỗi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dụng cụ đang sử dụng, không thể xóa!", "Thông báo", MessageBoxButtons.OK);
            }*/
        }
    }
}
