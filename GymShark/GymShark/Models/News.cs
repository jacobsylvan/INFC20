using System;
using System.Data;

namespace GymShark
{
    public class News
    {
        private string name;
        private string content;
        private string date;
        private string id;

        public News(string name, string content, string date)
        {
            this.name = name;
            this.content = content;
            this.date = date;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public static News Create(IDataRecord record)
        {
            return new News
            {
                Id = record["id"].ToString(),
                Name = record["name"].ToString(),
                Content = record["content"].ToString(),
                Date = record["date"].ToString()
            };
        }


        public News()
        {
        }
    }
}
