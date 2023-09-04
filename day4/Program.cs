using System;
using System.Security.Cryptography;

namespace day4
{ 
    #region struct
    //struct complexnum
    //{
    //    public int Real { get; set; }
    //    int img;
    //    public int Img
    //    {
    //        set
    //        {
    //            if (value >= 0)
    //            {
    //                img = value;
    //            }
    //            else
    //            {
    //                img = 0;
    //            }
    //        }
    //    }
                    
        
    //     public string getstring()
    //     {
    //        return $"{Real}+{img}i";
            
    //     }
    //    #region constractor
    //    // the defualt predefined constractor
    //    //public complexnum()
    //    //{
    //    //    Real = 0;
    //    //    img = 0;
    //    //}
    //    public complexnum()// changing predefined constractor
    //    {
    //        Real = 1;
    //        img = 1;
    //    }

    //    public complexnum(int Real,int img)
    //    {
    //        this.Real = Real;
    //        this.img = img;
    //    }
    //    //public complexnum(int num)
    //    //{
    //    //   Real=img=num ;
    //    //}
    //    public complexnum(int Real):this(Real,0)//constractor chaining
    //    {
    //        //complexnum(Real,1) xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    //        // constractor chaining replace the next to lines 
    //        //this.Real=Real ;
    //        //img = 0;
    //    }
    //    #endregion
    //}
#endregion
    #region class
   class complexnum
{
    public int Real { get; set; }
    int img;
    public int Img
    {
        set
        {
            if (value >= 0)
            {
                img = value;
            }
            else
            {
                img = 0;
            }
        }
    }


    public string getstring()
    {
        return $"{Real}+{img}i";

    }
    #region constractor
    // the defualt predefined constractor
    //public complexnum()
    //{
    //    Real = 0;
    //    img = 0;
    //}
    public complexnum()// changing predefined constractor
    {
        Real = 1;
        //img = 1;
    }

    public complexnum(int Real, int img)
    {
        this.Real = Real;
        this.img = img;
    }
    //public complexnum(int num)
    //{
    //   Real=img=num ;
    //}
      public complexnum(int Real) : this(Real, 0)//constractor chaining
       {
        //complexnum(Real,1) xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        // constractor chaining replace the next to lines 
        //this.Real=Real ;
        //img = 0;
       }

        //~complexnum()//dedstractor
        //{
        //    Console.WriteLine("destractor");
        //}
    #endregion
}
    class subject
    {
        public int id { get; set; }
        public String name { get; set; }
        public int duration { get; set; }

        public subject()
        {
            id = 1;
            duration = 12;
        }
        public subject(int id, String name)
        {
            this.id = id;
            this.name = name;
        }
        public subject(int id, String name, int diuraton)
        {
            this.id = id;
            this.name = name;
            this.duration = diuraton;
        }
        public string getstring()
        {
            return $"{id}--{name} \t\t {duration} hours";
        }
    }
    #region has-A
    //class student
    //{
    //    public int id { get; set; }
    //    public string name { get; set; }
    //    public int age { get; set; }
    //    public subject sub { get; set; }

    //    public student() 
    //    { 
    //        id=1;
    //    }
    //    public student(int id , String name , int age, subject sub)
    //    {
    //        this.id = id;
    //        this.name = name;
    //        this.age = age; 
    //        this.sub = sub;
    //    }
    //    public String tostring()
    //    {
    //        return $"{id}--{name}\t\t{age} years old \n{sub.getstring()}";
    //    }
    //}
    #endregion
    class student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public subject[] sub { get; set; }

        public student()
        {
            id = 1;
        }
        public student(int id, String name, int age, int numOfSubjects)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            sub = new subject[numOfSubjects];
        }
        public student(int id, String name, int age)//fixed number of subjects
        {
            this.id = id;
            this.name = name;
            this.age = age;
            sub = new subject[3];
        }
        public student(int id, String name, int age, subject[] sub)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.sub = sub;
        }
        public String tostring()
        {
            string txt= $"{id}--{name}\t\t{age} years old \n";
            for (int i = 0; i < sub.Length; i++) 
            {
                txt += sub[i].getstring() + "\n";
            }
            return txt ;
        }
    }
    #endregion
    #region lab
    class player
    {
        public int shirtNum { get; set; }
        public string name { get; set; }
        public string  position { get; set; }
        public player()
        {
            this.shirtNum = 1;
        }
        public player(int shirtnum , string name , string position)
        {
            this.shirtNum= shirtnum;
            this.name = name;
            this.position= position;
            
        }

        public string getstring()
        {
            return $"{name}--{shirtNum}--{position}";
        }
        public void showplayer(player s) 
        {
            Console.WriteLine(s.getstring());
        }
    }
    class team
    {
        public int id { get; set; }
        public string name { get; set; }

        public string desc { get; set; }
        public player[] players { get; set; }

        public team()
        {
            id = 1;
            players = new player[1];
        }

        public team(int id ,string name,string desc)
        {
            this.id = id;
            this.name = name;
            this.desc = desc;
            players = new player[5];
            
        }
        public team(int id, string name, string desc,int numOfPlayers)
        {
            this.id = id;
            this.name = name;
            this.desc = desc;
            players = new player[numOfPlayers];
        }
        public team(int id, string name, string desc, player[] players)
        {
            this.id = id;
            this.name = name;
            this.desc = desc;
            this.players = players;
        }
        public string getstring()
        {
           string txt=  $"{id}--{name}--{desc} \n";

            for(int i=0;  i < players.Length; i++)
            {
                txt +="\n" + players[i].getstring();
            }

            return txt ;
         
        }
        public void showteam(team s)
        {
            Console.WriteLine(s.getstring());
        }
    }
    #endregion
    class progrma
    {
        static void Main()
        {
            #region constractor
            //complexnum c =new complexnum();// defualt constractor
            //c.Real = 1;
            //c.Img = 2;
            //Console.WriteLine(c.getstring());

            //complexnum c2=new complexnum(2,4);//overload constractor
            //Console.WriteLine(c2.getstring());

            //complexnum c1 = new complexnum();// new defualt constractor

            //Console.WriteLine(c1.getstring());

            //complexnum c3= new complexnum(6);//overload constractor
            //Console.WriteLine(c3.getstring());
            #endregion
            #region this keyword
            //complexnum c= new complexnum();
            //complexnum c1= new complexnum(2,4);
            //complexnum c3 = new complexnum(2);
            #endregion
            #region class
            //ref datatype
            //store ref stack , data(object) heap
            // new is required // storage , call constracor , return ref to be stored in stacke
            //complexnum c;//just define ref in stack
            //c = new complexnum(); //allocation in heap (create object )
            //complexnum c1= new complexnum(2,4);
            //Console.WriteLine(c1.getstring());
            //c = c1; // c now have c2 ref any change appear in both
            //c.Img = 1;
            //Console.WriteLine(c1.getstring());
            //complexnum c2 = new complexnum();
            //Console.WriteLine(c2.getstring());// will print 1+0i because of defualt constractor
            #endregion
            #region array of subjects
            //subject s =new subject(1,"oop",13);
            //Console.WriteLine(s.getstring());
            //subject[] array=new subject[5];

            //Console.WriteLine("enter number of subjects");
            //int numOfSubjects=int.Parse(Console.ReadLine());
            //subject[] array = new subject[numOfSubjects];
            //for (int i = 0; i < numOfSubjects; i++)
            //{
            //    array[i]=new subject();// الاختلاف بين ال class و struct
            //    Console.WriteLine("enter id");
            //    array[i].id = int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter name");
            //    array[i].name = Console.ReadLine();
            //    Console.WriteLine("enter duration");
            //    array[i].duration = int.Parse(Console.ReadLine());

            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i].getstring());
            //}
            #endregion
            #region relation between classes is-a ,has-a
            //student s=new student(1,"ali",8);
            //Console.WriteLine(s.tostring());

            //student s = new student(1, "ali", 22,new subject(1,"oop",30));
            //Console.WriteLine(s.tostring());

            ////or
            //subject alisub = new subject(1, "oop", 30);
            //student s1 = new student(1, "ali", 22,alisub );
            //Console.WriteLine( s1.tostring() );
            //subject[] subs = new subject[3] { new subject(1, "oop", 22), new subject(1, "sql", 25), new subject(1, "c3", 22) };//pass the array dircetly
            //student s=new student(1,"ali",22,subs);
            //Console.WriteLine(s.tostring());

            //student s1 = new student(1, "ali", 22,3);// pass only the size
            //s1.sub[0] = new subject(1, "oop", 22);
            //s1.sub[0] = new subject(1, "oop", 22);
            //s1.sub[0] = new subject(1, "oop", 22);
            //s1.sub[0] = new subject(1, "oop", 22);

            //student s1 = new student(1, "ali", 22);// sixed size the size
            //s1.sub[0] = new subject(1, "oop", 22);
            //s1.sub[0] = new subject(1, "oop", 22);
            //s1.sub[0] = new subject(1, "oop", 22);
            //s1.sub[0] = new subject(1, "oop", 22);


            #endregion

            #region lab
            // entering player
            //Console.WriteLine("enter player shirt number");
            //int shirtnum=int.Parse(Console.ReadLine());
            //Console.WriteLine("enter player name");
            //String name=Console.ReadLine();
            //Console.WriteLine("enter player position");
            //String position = Console.ReadLine();
            //player a1 = new player(shirtnum,name,position);
            //a1.showplayer(a1);

            //entering team with fixed size 5

            //Console.WriteLine("enter team  id");
            //int id = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter team name");
            //String teamname = Console.ReadLine();
            //Console.WriteLine("enter team desc");
            //String desc = Console.ReadLine();
            //team t= new team(id,teamname,desc);
            //for(int i = 0; i < 5; i++)
            //{
            //    t.players[i] = new player();
            //    Console.WriteLine("enter player shirt number");
            //    t.players[i].shirtNum = int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter player name");
            //    t.players[i].name = Console.ReadLine();
            //    Console.WriteLine("enter player position");
            //    t.players[i].position = Console.ReadLine();
            //}
            //t.showteam(t);

            //entering team with size decided by user
            //Console.WriteLine("enter team  number of players");
            //int numofplayers = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter team  id");
            //int id = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter team name");
            //String teamname = Console.ReadLine();
            //Console.WriteLine("enter team desc");
            //String desc = Console.ReadLine();
            //team t = new team(id, teamname, desc, numofplayers);
            //for (int i = 0; i < numofplayers; i++)
            //{
            //    t.players[i] = new player();
            //    Console.WriteLine("enter player shirt number");
            //    t.players[i].shirtNum = int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter player name");
            //    t.players[i].name = Console.ReadLine();
            //    Console.WriteLine("enter player position");
            //    t.players[i].position = Console.ReadLine();
            //}
            //t.showteam(t);

            //user enter players first then team
            //team t = new team();
            //Console.WriteLine("enter team  number of players");
            //int numofplayers = int.Parse(Console.ReadLine());
            //player[] players = new player[numofplayers];
            //for (int i = 0; i < numofplayers; i++)
            //{
            //    players[i] = new player();
            //    Console.WriteLine("enter player shirt number");
            //    players[i].shirtNum = int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter player name");
            //    players[i].name = Console.ReadLine();
            //    Console.WriteLine("enter player position");
            //    players[i].position = Console.ReadLine();
               
            //}
            //Console.WriteLine("enter team  id");
            //int id = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter team name");
            //String teamname = Console.ReadLine();
            //Console.WriteLine("enter team desc");
            //String desc = Console.ReadLine();
            //t.id=id;
            //t.name = teamname;
            //t.desc = desc;
            //t.players= players;
            //t.showteam(t);

            #endregion
        }
    }
    
}

