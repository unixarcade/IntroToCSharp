using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caledar
{
    public class Calendar
    {

        public enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Thursday,
            Friday,
            Saturday

        }
        public DateTime Today
        { get { return default(DateTime); } }

        public IEnumerable<Appointment> GetAppointments()
        {
            return null;
        }

        public void AppointmentError ShecduleRepsonse(DateTime startTime, TimeSpan duration,
        Person withWhom,
        Location where,
        string description) { }


    }
}
