using System;

namespace Mob
{
    public class Mobile
    {
        private string mobileOwnerName;
        private string mobileNumber; // SIM number 
        private string mobileBalance; 
        private string mobileOSName;

        private bool locked;

        //empty constructor

        public Mobile()
        {

        }

        //valued constructor

        public Mobile(string onm, string mn, string mb, string mo)
        {
            ownerName = onm;
            Number = mn;
            Balance = mb;
            OS = mo;
        }

        //properties
        public string ownerName
        {
            get
            {
                return mobileOwnerName;
            }
            set
            {
                mobileOwnerName = value;
            }
        }

        public string Number 
        {
            get 
            {
                return mobileNumber;
            }
            set
            {
                mobileNumber = value;
            }
        }

        public string Balance 
        {
            get
            {
                return mobileBalance;
            }
            set
            {
                mobileBalance = value;
            }
        }

        public string OS
        {
            get
            {
                return mobileOSName;
            }
            set
            {
                mobileOSName = value;
            }
        }

        public bool Locked
        {
            get 
            {
                return locked;
            }
            set
            {
                locked = value;
            }
        }
            //boolean check
        public bool isLocked()
        {
            char A;

            Console.WriteLine("To see information phone has to be \"Unlocked\".\nDo you want to unlock your phone? \nTo Unlock enter => Y\nTo Exit Enter => N");
            A = Char.Parse(Console.ReadLine());

            if(A == 'Y' || A == 'y')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            //show info
        public void ShowInfo()
        {
            if(isLocked())
            {
                Console.WriteLine("-------Succesfully Unlocked-----------");
                Console.WriteLine("Mobile Owner Name: "+ownerName+"\nMobile Number: "+Number+"\nMobile Balance: "+Balance+"\nOs Name: "+OS);
                Console.WriteLine("----------------Thank You--------------");
            }
            else
            {
                Console.WriteLine("\nYour phone is locked.\n");
                Console.WriteLine("----------------Thank You--------------");
            }
        }
            //recharge
        public void Recharge(int amount)
        {
            if(isLocked())
            {
                int tmp;
                Console.WriteLine("-------Succesfully Unlocked-----------");
                Console.WriteLine("\nYour Previous Balance Was => "+Balance);
                tmp = Convert.ToInt16(Balance);
                tmp += amount;
                Balance = tmp.ToString();
                Console.WriteLine("\nCurrent Balance => "+Balance);
                Console.WriteLine("\n----------------Thank You--------------\n");
            }
            else
            {
                Console.WriteLine("\nYour phone is locked.\n");
                Console.WriteLine("\n----------------Thank You--------------\n");
            }
        }

        public void CallSomeone(int timeDuration)
        {
            if(isLocked())
            {
                Console.WriteLine("--------Calling----------");
                Console.WriteLine("Calling Cost => {0} Tk",timeDuration);
                Console.WriteLine("\n----------------Thank You--------------\n");
            }
            else
            {
                Console.WriteLine("\nYour phone is locked.\n");
                Console.WriteLine("\n----------------Thank You--------------\n");
            }
        }

    }
}