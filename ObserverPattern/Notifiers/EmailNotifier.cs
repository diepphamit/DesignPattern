using ObserverPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Notifiers
{
    public class EmailNotifier : Observer
    {
        public EmailNotifier(Subject subject)
        {
            this.subject = subject;
            this.subject.AttachObserver(this);
        }
        public override void Notify(Subject sunject, object arg)
        {
            if (subject is VideoData videoData)
            {
                Console.WriteLine(string.Format("Email \t {0} \t Description {1} \t File name: {2}",
                    videoData.GetTitle(), videoData.GetDescription(), videoData.GetDescription()));
            }
        }
    }
}
