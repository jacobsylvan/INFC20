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
        private Boolean isFinished;
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
        public Boolean IsFinished{
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
            session.Date = (DateTime)record[1];
            session.StartTime = record[2].ToString();
            session.Duration = (int)record[3];
            session.IsFinished = (bool)record[4];
            instructor.Id = (Int16)record[5];
            instructor.Name = record[6].ToString();
            place.Id = (Int16)record[7];
            place.Name = record[8].ToString();
            sessionType.Id = (Int16)record[9];
            sessionType.Name = record[10].ToString();
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
