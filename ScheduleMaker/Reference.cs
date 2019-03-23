using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleMaker
{
    public class Reference
    {
        public Reference() {
            Rooms = new List<Room>();
            Lecturers = new List<Lecturer>();
            Pairs = new List<Pair>();
            Disciplines = new List<Discipline>();
            Schedules = new List<Schedule>();
        }

        public List<Room> Rooms { get; set; }
        public List<Lecturer> Lecturers { get; set; }
        public List<Pair> Pairs { get; set; }
        public List<Discipline> Disciplines { get; set; }

        public List<Schedule> Schedules { get; set; }
    }

    public class Lecturer {
        public string Name { get; set; }
        public List<Discipline> Disciplines { get; set; }
    }

    public class Room {
        public string ShortName { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
    }

    public class Pair {
        public TimeSpan BeginTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Name { get; set; }
    }

    public class Discipline {
        public string Name { get; set; }
    }

    public class StudyYearPart {
        public ushort BeginYear { get; set; }
        public ushort EndYear { get; set; }
        public byte SemesterNumber { get; set; }
    }

    public class Group {
        public string Name { get; set; }
    }

    public class Schedule {
        public StudyYearPart YearPart { get; set; }
        public List<StudyEvent> StudyEvents { get; set; }
    }

    public class StudyEvent {
        public Group Group { get; set; }
        public Discipline Discipline { get; set; }
        public Pair Pair { get; set; }
    }
}
