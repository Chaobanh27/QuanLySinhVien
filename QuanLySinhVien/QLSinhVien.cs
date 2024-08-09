using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class QLSinhVien
    {
        //sử dụng kiểu dữ liệu SinhVien cho danh sách là để chỉ định rằng danh sách này sẽ lưu trữ các đối tượng của lớp SinhVien hoặc các lớp con của nó.
        //Điều này giúp đảm bảo rằng chỉ có các đối tượng SinhVien hoặc các đối tượng có quan hệ kế thừa với lớp SinhVien mới được thêm vào danh sách.
        //Các phần tử khác không thuộc kiểu SinhVien sẽ không được chấp nhận vào danh sách này.
        private List<SinhVien> ListSinhVien = new List<SinhVien>();


        //hàm tạo id cho sinh viên
        public int GenerateId()
        {
            int max = 1;
            if(ListSinhVien != null && ListSinhVien.Count > 0)
            {
                max = ListSinhVien[0].Id;
                foreach(SinhVien sv in ListSinhVien)
                {
                    if(max < sv.Id)
                    {
                        max = sv.Id;
                    }
                }
                max++;
            }
            return max;
        }

        //hàm tính số lượng sinh viên
        public int SoLuongSV()
        {
            int count = 0;
            if(ListSinhVien != null)
            {
                count = ListSinhVien.Count;
            }
            return count;
        }

        //hàm nhập thông tin sinh viên
        public void NhapSV()
        {
            SinhVien sv = new SinhVien();
            sv.Id = GenerateId();
            Console.Write("Nhap ten sinh vien: ");
            sv.Name = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap gioi tinh sinh vien: ");
            sv.Gender = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap tuoi sinh vien: ");
            sv.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap diem toan: ");
            sv.DiemToan = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem ly: ");
            sv.DiemLy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem hoa: ");
            sv.DiemHoa = Convert.ToDouble(Console.ReadLine());

            TinhTB(sv);
            XepLoaiHocLuc(sv);
            ListSinhVien.Add(sv);
        }

        //hàm cập nhật thông tin sinh viên
        public void UpdateSinhVien(int id) 
        {
            SinhVien sv = FindByID(id);
            if( sv != null)
            {
                Console.WriteLine("Nhap ten sinh vien: ");
                string name = Convert.ToString(Console.ReadLine()); 
                if(name != null && name.Length > 0)
                {
                    sv.Name = name;
                }
                Console.WriteLine("Nhap gioi tinh sinh vien: ");
                string gender = Convert.ToString(Console.ReadLine());
                if(gender != null && gender.Length > 0)
                {
                    sv.Gender = gender;
                }
                Console.WriteLine("Nhap tuoi sinh vien: ");
                string age = Convert.ToString(Console.ReadLine());
                if(age != null && age.Length > 0)
                {
                    sv.Age = Convert.ToInt32(age);
                }
                Console.Write("Nhap diem toan: ");
                string diemToanStr = Convert.ToString(Console.ReadLine());
                if (diemToanStr != null && diemToanStr.Length > 0)
                {
                    sv.DiemToan = Convert.ToDouble(diemToanStr);
                }

                Console.Write("Nhap diem ly: ");
                string diemLyStr = Convert.ToString(Console.ReadLine());
                if (diemLyStr != null && diemLyStr.Length > 0)
                {
                    sv.DiemLy = Convert.ToDouble(diemLyStr);
                }

                Console.Write("Nhap diem hoa: ");
                string diemHoaStr = Convert.ToString(Console.ReadLine());
                if (diemHoaStr != null && diemHoaStr.Length > 0)
                {
                    sv.DiemHoa = Convert.ToDouble(diemHoaStr);
                }
                TinhTB(sv);
                XepLoaiHocLuc(sv);
            }
            else
            {
                Console.WriteLine("Sinh vien co ID = {0} khong ton tai.", id);
            }
        } 

        //hàm tính điểm trung bình sinh viên
        public void TinhTB(SinhVien sv)
            //tham số sẽ là biến sv với kiểu là đối tượng sinh viên vì vậy dữ liệu truyền vào sẽ là 1 đối tượng sinh viên
        {
            double DiemTB = (sv.DiemToan + sv.DiemLy + sv.DiemHoa) / 3;
            sv.DiemTB = Math.Round(DiemTB);
        }

        //hàm xếp loại học lực sinh viên
        public void XepLoaiHocLuc(SinhVien sv)
        {
            //tham số sẽ là biến sv với kiểu là đối tượng sinh viên vì vậy dữ liệu truyền vào sẽ là 1 đối tượng sinh viên
            if (sv.DiemTB >= 8)
            {
                sv.HocLuc = "Gioi";
            }
            else if (sv.DiemTB >= 6.5)
            {
                sv.HocLuc = "Kha";
            }
            else if (sv.DiemTB >= 5)
            {
                sv.HocLuc = "Trung Binh";
            }
            else
            {
                sv.HocLuc = "Yeu";
            }
        }

        //hàm tìm sinh viên theo id
        public SinhVien FindByID(int Id)
        {
            SinhVien searchResult = null;
            if (ListSinhVien != null && ListSinhVien.Count > 0)
            {
                foreach (SinhVien sv in ListSinhVien)
                {
                    if (sv.Id == Id)
                    {
                        searchResult = sv;
                    }
                }
            }
            return searchResult;
        }

        //hàm hiển thị thông tin sinh viên
        public void ShowSV(List<SinhVien> ListSV)
        {
            Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} {5, 5} {6, 5} {7, 10} {8, 10}",
                  "ID", "Name", "Sex", "Age", "Toan", "Ly", "Hoa", "Diem TB", "Hoc Luc");
            if (ListSV != null && ListSV.Count > 0)
            {
                foreach (SinhVien sv in ListSV)
                {
                    Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} {5, 5} {6, 5} {7, 10} {8, 10}",
                                      sv.Id, sv.Name, sv.Gender, sv.Age, sv.DiemToan, sv.DiemLy, sv.DiemHoa,
                                      sv.DiemTB, sv.HocLuc);
                }
            }
            Console.WriteLine();
        }

        public List<SinhVien> getlistSV()
        {
            return ListSinhVien;
        }


        //hàm xóa sinh viên trong danh sách theo id
        public bool DeleteById(int id)
        {
                bool IsDeleted = false;
                SinhVien sv = FindByID(id);
                if ( sv != null ) 
                {
                    IsDeleted = ListSinhVien.Remove(sv);
                }
                return IsDeleted;
        }

        //hàm tìm kiếm sinh viên trong danh sách theo tên
        public List<SinhVien> FindByName (String name)
        {
            //hàm sẽ trả về danh sách sinh viên phù hợp với đối số truyền vào
            //và thêm vào danh sách mới với tên biến là searchResult
            List<SinhVien> searchResult = new List<SinhVien>();
            if(ListSinhVien != null && ListSinhVien.Count > 0)
            {
                foreach(SinhVien sv in ListSinhVien)
                {
                    if(sv.Name.ToUpper().Contains(name.ToUpper()))
                    {
                        searchResult.Add(sv);
                    }
                }
            }
            return searchResult;
        }

        //Comparison<T> là một delegate được sử dụng trong .NET Framework để so sánh hai đối tượng của kiểu T
        private Comparison<SinhVien> compareDiemDelegate = (sv1, sv2) => sv1.DiemTB.CompareTo(sv2.DiemTB);
        private Comparison<SinhVien> compareNameDelegate = (sv1, sv2) => sv1.Name.CompareTo(sv2.Name);
        private Comparison<SinhVien> compareIdDelegate = (sv1, sv2) => sv1.Id.CompareTo(sv2.Id);
        //hàm sắp xếp sinh viên theo điểm trung bình
        public void SortByDiemTB()
        {
            ListSinhVien.Sort(compareDiemDelegate);
        }

        //hàm sắp xếp sinh viên theo tên
        public void SortByName()
        {
            ListSinhVien.Sort(compareNameDelegate);
        }

        //hàm sắp xếp sinh viên theo id
        public void SortByID()
        {
            ListSinhVien.Sort(compareIdDelegate);
        }

    }
}
