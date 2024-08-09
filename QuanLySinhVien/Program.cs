// See https://aka.ms/new-console-template for more information
using QuanLySinhVien;

QLSinhVien qlSinhVien = new QLSinhVien();

while (true)
{
    Console.WriteLine("\nCHUONG TRINH QUAN LY SINH VIEN C#");
    Console.WriteLine("*************************MENU**************************");
    Console.WriteLine("**  1. Them sinh vien.                               **");
    Console.WriteLine("**  2. Cap nhat thong tin sinh vien boi ID.          **");
    Console.WriteLine("**  3. Xoa sinh vien boi ID.                         **");
    Console.WriteLine("**  4. Tim kiem sinh vien theo ten.                  **");
    Console.WriteLine("**  5. Sap xep sinh vien theo diem trung binh (GPA). **");
    Console.WriteLine("**  6. Sap xep sinh vien theo ten.                   **");
    Console.WriteLine("**  7. Sap xep sinh vien theo ID.                    **");
    Console.WriteLine("**  8. Hien thi danh sach sinh vien.                 **");
    Console.WriteLine("**  0. Thoat                                         **");
    Console.WriteLine("*******************************************************");
    Console.Write("Nhap tuy chon: ");
    int key = Convert.ToInt32(Console.ReadLine());
    switch (key)
    {
        case 1:
            Console.WriteLine("\n1. Them sinh vien.");
            qlSinhVien.NhapSV();
            Console.WriteLine("\nThem sinh vien thanh cong!");
            break;
        case 2:
            if(qlSinhVien.SoLuongSV() > 0)
            {
                int id;
                Console.WriteLine("\n2. Cap nhat thong tin sinh vien. ");
                Console.Write("\nNhap ID: ");
                id = Convert.ToInt32(Console.ReadLine());
                qlSinhVien.UpdateSinhVien(id);
            }
            else
            {
                Console.WriteLine("\nSanh sach sinh vien trong!");
            }
            break;
        case 3:
            if (qlSinhVien.SoLuongSV() > 0)
            {
                int id;
                Console.WriteLine("\n3. Xoa sinh vien.");
                Console.Write("\nNhap ID: ");
                id = Convert.ToInt32(Console.ReadLine());
                if (qlSinhVien.DeleteById(id))
                {
                    Console.WriteLine("\nSinh vien co id = {0} da bi xoa.", id);
                }
            }
            else
            {
                Console.WriteLine("\nSanh sach sinh vien trong!");
            }
            break;
        case 4:
            if (qlSinhVien.SoLuongSV() > 0)
            {
                Console.WriteLine("\n4. Tim kiem sinh vien theo ten.");
                Console.Write("\nNhap ten de tim kiem: ");
                string name = Convert.ToString(Console.ReadLine());
                List<SinhVien> searchResult = qlSinhVien.FindByName(name);
                qlSinhVien.ShowSV(searchResult);
            }
            else
            {
                Console.WriteLine("\nSanh sach sinh vien trong!");
            }
            break;
        case 5:
            if (qlSinhVien.SoLuongSV() > 0)
            {
                Console.WriteLine("\n5. Sap xep sinh vien theo diem trung binh (GPA).");
                qlSinhVien.SortByDiemTB();
                qlSinhVien.ShowSV(qlSinhVien.getlistSV());
            }
            else
            {
                Console.WriteLine("\nSanh sach sinh vien trong!");
            }
            break;
        case 6:
            if (qlSinhVien.SoLuongSV() > 0)
            {
                Console.WriteLine("\n6. Sap xep sinh vien theo ten.");
                qlSinhVien.SortByName();
                qlSinhVien.ShowSV(qlSinhVien.getlistSV());
            }
            else
            {
                Console.WriteLine("\nSanh sach sinh vien trong!");
            }
            break;
        case 7:
            if (qlSinhVien.SoLuongSV() > 0)
            {
                Console.WriteLine("\n6. Sap xep sinh vien theo ID.");
                qlSinhVien.SortByID();
                qlSinhVien.ShowSV(qlSinhVien.getlistSV());
            }
            else
            {
                Console.WriteLine("\nSanh sach sinh vien trong!");
            }
            break;
        case 8:
            if(qlSinhVien.SoLuongSV() > 0)
            {
                Console.WriteLine("\n7. Hien thi danh sach sinh vien.");
                qlSinhVien.ShowSV(qlSinhVien.getlistSV());
            }
            else
            {
                Console.WriteLine("\n7. Khong co sinh vien nao");
            }
            break;
        case 0:
            Console.WriteLine("\nBan da chon thoat chuong trinh!");
            return;
        default:
            Console.WriteLine("\nKhong co chuc nang nay!");
            Console.WriteLine("\nHay chon chuc nang trong hop menu.");
            break;
    }
}
