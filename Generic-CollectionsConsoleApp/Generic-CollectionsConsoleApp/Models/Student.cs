using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_CollectionsConsoleApp.Models
{
    internal class Student
    {
        #region Fields
        static int _id;
        string _surname;
        string _name;
        byte _age;
        double _point;
        #endregion
        #region Constructor
        public Student(string surname,string name, double point)
        {
            _id++;
            Id = _id;
            this.Surname = surname;
            this.Name = name;
            this.Point = point;
        }
        #endregion

        #region Property
        public int Id 
        {
            get;           
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }
        public string Name

        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public byte Age
        {
            get
            {
                return _age;
            }
            set
            {
                try
                {
                    if (value < 0 || value > 150)
                    {
                        Console.WriteLine("Yaşı doğru daxil edin: ");
                    L3: string yasi = Console.ReadLine();
                        byte yas = Convert.ToByte(yasi);
                        value = yas;
                        if (value < 0 && value > 150)
                        {
                            Console.WriteLine("Yaşı doğru daxil edin: ");
                            goto L3;
                        }
                        else
                        {
                            _age = value;
                        }
                    }
                    else
                    {
                        _age = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }
        }
        public double Point
        {
            get
            {
                return _point;
            }
            set
            {
                try
                {
                    if (value > 100 || value < 0)
                    {
                    P1: Console.WriteLine("Point 0-100 aralığında olmalıdır");
                        Console.Write("Tələbənin balın daxil edin: ");
                        value = Convert.ToDouble(Console.ReadLine());
                        if (value > 100 || value < 0)
                        {
                            goto P1;
                        }
                        _point = value;
                    }
                    _point = value;
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        #endregion

        #region Method
        public void ShowInfo()
        {
            Console.WriteLine($"Student name: {Name}\n" +
                $"Student surname: {Surname}\n" +
                $"Student age: {Age}\n" +
                $"Studnet point: {Point}\n" +
                $"-------------------------");
        }
        #endregion

        #region <>Overloading
        public static bool operator >(Student student1, Student student2)
        {
            return student1.Point > student2.Point;
        }
        public static bool operator <(Student student1, Student student2)
        {
            return student1.Point > student2.Point;
        }
        #endregion

        public override string ToString()
        {
            return $"Student name: {Name}\n" +
                $"Student surname: {Surname}\n" +
                $"Student age: {Age}\n" +
                $"Studnet point: {Point}\n" +
                $"------------------------------";
        }

    }
}
