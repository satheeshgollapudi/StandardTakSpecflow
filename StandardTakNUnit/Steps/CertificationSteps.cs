using System;
using test.AssertHelpers;
using test.Model;
using test.Pages.components;
using test.Pages.Components;
using test.Utils;

namespace test.Steps
{
	public class CertificationSteps
	{
        ProfileCertificationOverviewComponent profileCertificationOverviewComponent;
        AddAndUpdatCertificationComponent addAndUpdateCertificationComponent;

        public CertificationSteps()
		{


            profileCertificationOverviewComponent = new ProfileCertificationOverviewComponent();
            addAndUpdateCertificationComponent = new AddAndUpdatCertificationComponent();

        }


        public void addCertification()
		{
            Model.CertificationModel certification = new Model.CertificationModel();

            string path = @"C:\Users\gskum\OneDrive\Desktop\StandardTakNUnit\StandardTakNUnit\TestData\Certification.json";


            JsonReader er = JsonReader.read(path);
            certification.setcertificate(er.certificate);
            certification.setfrom(er.from);
            certification.setyear(er.year);
            

            profileCertificationOverviewComponent.clickAddCertificationButton();

            addAndUpdateCertificationComponent.addCertification(certification);
            String acutalSuccessMessage = addAndUpdateCertificationComponent.getSuccessMessage();

            AssertHelper.assertAddCertificationSuccessMessage(certification.getcertificate() +" has been added to your certification", acutalSuccessMessage);
        }

    }
}


