using ObserverPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class VideoData : Subject
    {
        private string _title;
        private string _description;    
        private string _fileName;

        public string GetTitle()
        {
            return _title;  
        }

        public void SetTitle(string title)
        {
            _title = title;
            VideoDataChanged();
        }

        public string GetDescription()
        {
            return _description;
        }

        public void SetDescription(string description)
        {
            _description = description;
            VideoDataChanged();
        }

        public string GetFileName()
        {
            return _fileName;
        }

        public void SetFileName(string fileName)
        {
            _fileName = fileName;
            VideoDataChanged();
        }

        private void VideoDataChanged()
        {
            NotifyObservers(this, null);
        }
    }
}
