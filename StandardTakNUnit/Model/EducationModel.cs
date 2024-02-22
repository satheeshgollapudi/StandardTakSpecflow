using System;
namespace test.Model
{
	public class EducationModel
	{
	        
        private String country;
        private String university;
        private String title;
        private String degree;
        private String graduationYear;



        public String getCountry()
        {
            return country;
        }

        public void setCountry(String country)
        {
            this.country = country;
        }

        public String getUniversity()
        {
            return university;
        }

        public void setUniversity(String university)
        {
            this.university = university;
        }

        public String getTitle()
        {
            return title;
        }

        public void setTitle(String title)
        {
            this.title = title;
        }

        public String getDegree()
        {
            return degree;
        }

        public void setDegree(String degree)
        {
            this.degree = degree;
        }

        public String getGraduationYear()
        {
            return graduationYear;
        }

        public void setGraduationYear(String graduationYear)
        {
            this.graduationYear = graduationYear;
        }

    }
}

