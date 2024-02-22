using System;
namespace test.Model
{
	public class CertificationModel
    {
	        
        private String certificate;
        private String from;
        private String year;
        



        public String getcertificate()
        {
            return certificate;
        }

        public void setcertificate(String certificate)
        {
            this.certificate = certificate;
        }

        public String getfrom()
        {
            return from;
        }

        public void setfrom(String from)
        {
            this.from = from;
        }

        public String getyear()
        {
            return year;
        }

        public void setyear(String year)
        {
            this.year = year;
        }

       
    }
}

