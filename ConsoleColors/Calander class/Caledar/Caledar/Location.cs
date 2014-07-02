using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caledar
{
    class Location
    {
    }
}


public class Appointment
{
    public DateTime startTime { get; private set; }
    public TimeSpan duration { get; private set; }
    public Person withWhom { get; private set; }
    public Location where { get; private set; }
    public string description { get; private set; }
}

public Appointment(){

}

public Appointment(DateTime starttime, TimeSpan duration, Person withWhom, Location where, string description){
startTime = starttime;
Duration = duration;
this.withWhom = withWhom;

}