using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interactiveCalendareForParents
{
    class DoctorsAppointments
    {
        protected string nearestDoctorsAppointment="";
        protected Baby _baby;

        public DoctorsAppointments(Baby baby)
        {
            _baby = baby;
            whenNearestDoctorsAppointment();
        }

        private void whenNearestDoctorsAppointment()
        {
            throw new NotImplementedException();
        }
    }
}
