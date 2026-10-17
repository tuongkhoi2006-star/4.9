using System;

namespace WinFormsApp4._9
{
    public class Appointment
    {
        public string Id { get; set; }
        public string PatientName { get; set; }
        public string Phone { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public string Doctor { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }

        // Override ToString for debugging
        public override string ToString()
        {
            return $"{Id} - {PatientName} ({Phone}) @ {AppointmentDateTime:yyyy-MM-dd HH:mm} [{Status}]";
        }
    }
}
