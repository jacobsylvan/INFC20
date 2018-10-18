using System;
using System.Collections.Generic;
using System.Data;

namespace GymShark
{
    public class Session
    {
        private int sessionId;
        private DateTime date;
        private string startTime;
        private int duration;
        private int isFinished;
        private Instructor instructor;
        private Place place;
        private SessionType sessionType;
       

        public Session(int sessionId,  DateTime date, Boolean isFinished){
            this.sessionId = sessionId;
            this.date = date;

        }

        public int SessionId{
            get { return sessionId; }
            set { sessionId = value; }
        }
        
        public DateTime Date{
            get { return date; }
            set { date = value; }
        }
        public string StartTime{
            get { return startTime; }
            set { startTime = value; }
        }
        public int Duration{
            get { return duration; }
            set { duration = value; }
        }
        public int IsFinished{
            get { return isFinished; }
            set { isFinished = value; }
        }
        public Instructor Instructor{
            get { return instructor; }
            set { instructor = value; }
        }
        public Place Place{
            get { return place; }
            set { place = value; }
        }
        public SessionType SessionType{
            get { return sessionType; }
            set { sessionType = value; }
        }

        public static Session Create(IDataRecord record)
        {
            Session session = new Session();
            Instructor instructor = new Instructor();
            Place place = new Place();
            SessionType sessionType = new SessionType();

            session.SessionId = (Int16)record[0];
            Console.WriteLine(session.SessionId);
            session.Date = (DateTime)record[1];
            Console.WriteLine(session.Date);
            session.StartTime = record[2].ToString();
            Console.WriteLine(session.StartTime);
            session.IsFinished = (int)record[3];
            Console.WriteLine(session.IsFinished);
            instructor.Id = (Int16)record[4];
            Console.WriteLine(instructor.Id);
            instructor.Name = record[5].ToString();
            Console.WriteLine(instructor.Name);
            place.Id = (Int16)record[6];
            place.Name = record[7].ToString();
            sessionType.Id = (Int16)record[8];
            sessionType.Name = record[9].ToString();
            session.Instructor = instructor;
            session.Place = place;
            session.SessionType = sessionType;
            
            return session;
        }
    

    public Session()
        {
        }
    }
}
