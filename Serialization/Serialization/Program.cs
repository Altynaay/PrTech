using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MySerialization
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //f1();
            f2();
            //f3();
            //f4();

        }
        [Serializable]
        class Complex
        {
            public int x, y;
            public Complex(int x, int y) //constructor that initializes info
            {
                this.x = x;
                this.y = y;
            }
            static int gcd(int x, int y)
            {
                if (x == 0)
                    return y;
                return gcd(y % x, x);
            }
            public override string ToString()
            {
                return this.x / gcd(this.x, this.y) + "/" + this.y / gcd(this.x, this.y);
            }
            public static Complex operator +(Complex x, Complex y)
            {
                Complex c = new Complex(x.x * y.y + y.x * x.y, x.y * y.y);
                return c;
            }
            public static Complex operator -(Complex x, Complex y)
            {
                Complex c = new Complex(x.x * y.y - y.x * x.y, x.y * y.y);
                return c;
            }
            public static Complex operator *(Complex x, Complex y)
            {
                Complex c = new Complex(x.x * y.x, x.y * y.y);
                return c;
            }
            public static Complex operator /(Complex x, Complex y)
            {
                Complex c = new Complex(x.x * y.y, y.x * x.y);
                return c;
            }
        }
        static void f1()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("test.ser", FileMode.OpenOrCreate, FileAccess.ReadWrite);//create or open test.ser file from serialization file

            Student s = new Student();
            s.setInfo();//take information from setInfo
            Complex com = new Complex(1, 4);
            Complex mum = new Complex(2, 4);
            Complex sum = com + mum;

            try
            {
                bf.Serialize(fs, sum);
            }
            /*try
            {
                bf.Serialize(fs, s);//save file by binaryformatter with information s
            }*/
            catch
            {
                Console.Write("serialize error");// if try is not work program write "serialize error"
            }
            finally
            {
                fs.Close();// close opened or created file with
            }
        }
        static void f2()
        {
            BinaryFormatter bf = new BinaryFormatter(); //create binary formatter bf
            FileStream fs = new FileStream("test.ser", FileMode.OpenOrCreate, FileAccess.ReadWrite);//create or open test.ser file from serialization file

            try
            {
                Complex sum = bf.Deserialize(fs) as Complex;
                Console.Write(sum);
                Console.ReadKey();
            }
            /*try//take inforamation from test.ser
            {
                Student s = bf.Deserialize(fs) as Student;
                Console.Write(s);
                Console.ReadKey();
            }*/
            catch// if try is not work program write Deserialize error
            {
                Console.Write("Deserialize error");
            }
            finally// close opened or created file with
            {
                fs.Close();
            }
        }
        static void f3()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            FileStream fs = new FileStream("test.xml", FileMode.OpenOrCreate, FileAccess.Write);
            
            Student s = new Student();
            s.setInfo();
            Complex a = new Complex(3,4);
            Complex b = new Complex(5,6);
            Complex sum = a + b;
            try
            {
                xs.Serialize(fs, sum);
            }
            /*try
            {
                xs.Serialize(fs, s);
            }*/
            catch
            {
                Console.Write("error");
            }
            finally
            {
                fs.Close();
            }

        }
        static void f4()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            FileStream fs = new FileStream("test.xml", FileMode.Open, FileAccess.Read);

            try
            {
                Student s = xs.Deserialize(fs) as Student;
                Console.Write(s);
                Console.ReadKey();
            }
            catch
            {
                Console.Write("error");
            }
            finally
            {
                fs.Close();
            }
        }
    }
}