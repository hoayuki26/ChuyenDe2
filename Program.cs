using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan
{
    class Phong
    {
        protected int songay;
        public Phong(int songay)
        {
            this.songay = songay;
        }
        public virtual double Tinhtien()
        {
            return 0;
        }
        public virtual void Hien()
        {

        }
    }
    class PhongA : Phong
    {
        private int tiendv;
        public PhongA(int songay) : base(songay)
        {
            Console.WriteLine("Nhap vao tien dich vu: ");
            tiendv = int.Parse(Console.ReadLine());

        }
        public override double Tinhtien()
        {
            if (songay < 5)
                return songay * 80 + tiendv;
            else
                return (5 * 80 + (songay - 5) * 80 * 0.9) + tiendv;
        }
        public override void Hien()
        {
            Console.WriteLine("Day la dich vu phong A");
            Console.Write("Tien dich vu la:{0} ", tiendv);
            Console.Write("Tien phai tra la:{0} ", Tinhtien());
        }
    }
    class PhongB : Phong
    {
        public PhongB(int songay) : base(songay)
        {
        }
        public override double Tinhtien()
        {
            return songay * 40;
        }
        public override void Hien()
        {
            Console.WriteLine("Day la dich vu phong B");
            Console.Write("Tien phai tra la:{0} ", Tinhtien());
        }
    }
    class PhongC : Phong
    {
        public PhongC(int songay) : base(songay)
        {

        }
        public override double Tinhtien()
        {

            return songay * 40;
        }
        public override void Hien()
        {
            Console.WriteLine("Day la dich vu phong C");
            Console.Write("Tien phai tra la:{0} ", Tinhtien());
        }
    }
    class Khachhang
    {
        private string tenkhach;
        private int songay;
        private Phong loaiphong;
        public void Nhap()
        {
            Console.WriteLine("Nhap thong tin cua khach hang: ");
            Console.Write("Nhap ten khach hang: ");
            tenkhach = Console.ReadLine();
            Console.Write("Nhap so ngay: ");
            songay = int.Parse(Console.ReadLine());
            Console.WriteLine("Cho biet loai phong dinh thue A, B, or C");
            char ch = char.Parse(Console.ReadLine());
            switch (char.ToUpper(ch))
            {
                case 'A': loaiphong = new PhongA(songay); break;
                case 'B': loaiphong = new PhongB(songay); break;
                case 'C': loaiphong = new PhongC(songay); break;

            }
        }
        public void Hien1()
        {
            Console.WriteLine("THONG TIN HOA DON CUA KHACH HANG");
            Console.WriteLine("Ho ten khach hang: " + tenkhach);
            Console.WriteLine("So ngay o: " + songay);
            Console.WriteLine("Khach hang da su dung: ");
            loaiphong.Hien();
        }
    }
    class App
    {
        static void Main(string[] args)
        {
            Khachhang t = new Khachhang();
            t.Nhap();
            t.Hien1();
            Console.ReadKey();
        }
    }
}
