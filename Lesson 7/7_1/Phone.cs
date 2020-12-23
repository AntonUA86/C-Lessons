using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOne
{
    class Phone : iPhone
    {
        public void call()
        {
            Console.WriteLine("Гудок");
        }

        string model;
        int yearOfIssue;
        string connect;
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public int YearOfIssue
        {
            get
            {
                return yearOfIssue;
            }
            set
            {
                yearOfIssue = value;
            }
        }
        public string Connect
        {
            get
            {
                return connect;
            }
            set
            {
                connect = value;
            }
        }



        public Phone(string model, int yearOfIssue, string connect)
        {
            Model = model;
            YearOfIssue = yearOfIssue;
            Connect = connect;

        }
    }

    class RadioPhone : Phone
    {

        bool voicemail { get; set; }
        public RadioPhone(string model, int yearOfIssue, string connect, bool voicemail)
            : base(model, yearOfIssue, connect)
        {
            this.voicemail = voicemail;
        }



    }

    class SMSPhone : RadioPhone
    {
        bool shortMessageService { get; set; }

        public SMSPhone(string model, int yearOfIssue, string connect, bool voicemail, bool ShortMessageService)
            : base(model, yearOfIssue, connect, voicemail)
        {
            this.shortMessageService = shortMessageService;
        }


    }

    class ScreenPhone : SMSPhone
    {
        string screen { get; set; }

        public ScreenPhone(string model, int yearOfIssue, string connect, bool voicemail, bool shortMessageService, string screen)
               : base(model, yearOfIssue, connect, voicemail, shortMessageService)
        {
            this.screen = screen;
        }
    }
    class Smartphone : ScreenPhone
    {

        public Smartphone(string model, int yearOfIssue, string connect, bool voicemail, bool shortMessageService, string screen)
               : base(model, yearOfIssue, connect, voicemail, shortMessageService, screen)
        { }
    }
}













