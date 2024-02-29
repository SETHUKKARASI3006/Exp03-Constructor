using System;
namespace Constructor1
{
   public class Program
   {
    int exp,bs,insurance;
    string name,designation;
    float hra,ta,gs;
    public Program(string name,string designation,int exp,int bs,int insurance)
    {
        this.name=name;
        this.designation=designation;
        this.exp=exp;
        this.bs=bs;
        this.insurance=insurance;
    }
    public void salary()
    {
        hra=(float)0.2*bs;
        ta=(float)0.1*bs;
        gs=bs+hra+ta-insurance;
    }
    public void display()
    {
        Console.WriteLine("Name:"+name);
        Console.WriteLine("Designation:"+designation);
        Console.WriteLine("Number of expierence:"+exp);
        Console.WriteLine("Basic salary:"+bs);
        Console.WriteLine("Insurance:"+insurance);
        Console.WriteLine("Gross salary:"+gs);
    }
   }
   public class Exp3
   {
       static void Main(String[] args)
       {
        Program obj1=new Program("Raja","Tester",3,10000,1000);
        obj1.salary();
        obj1.display();
        Program obj2=new Program("Rani","Coder",2,8000,800);
        obj2.salary();
        obj2.display();
       }
   }
}