using System;
using System.Linq;

namespace WebApplication3.Models
{
    public class DbInitializer
    {
        public static void Initialize(InsuranceCompany11Context db)
        {
            db.Database.EnsureCreated();

            if (db.Staffs.Any() && db.Risks.Any() && db.ClientGroups.Any())
            {
                return;
            }

            Random randObj = new Random(1);

            string[] name = { "staffName1", "staffName2", "staffName3", "staffName4", "staffName5" };
            int count_staffName_voc = name.GetLength(0);
            string[] post = { "post1", "post2", "post3", "post4", "post5" };
            int count_staffPost_voc = post.GetLength(0);
            string[] experience = { "experience1", "experience2", "experience3", "experience4", "experience5" };
            int count_staffExperience_voc = experience.GetLength(0);
            for (int ID = 1; ID <= 1000; ID++)
            {
                string staffName = name[randObj.Next(count_staffName_voc)];
                string staffPost = post[randObj.Next(count_staffPost_voc)];
                string staffExperience = experience[randObj.Next(count_staffExperience_voc)];
                db.Staffs.Add(new Staffs { StaffName = staffName, StaffPost = staffPost, StaffExperience = staffExperience });
            }
            db.SaveChanges();

            string[] nameRisks = { "nameRisks1", "nameRisks2", "nameRisks3", "nameRisks4", "nameRisks5" };
            int count_nameRisks_voc = nameRisks.GetLength(0);
            string[] RiskDescription = { "RiskDescription1", "RiskDescription2", "RiskDescription3", "RiskDescription4", "RiskDescription5" };
            int count_RiskDescription_voc = RiskDescription.GetLength(0);
            string[] averageProbability = { "averageProbability1", "averageProbability2", "averageProbability3", "averageProbability4", "averageProbability5" };
            int count_averageProbability_voc = averageProbability.GetLength(0);
            for (int ID = 1; ID <= 1000; ID++)
            {
                db.Risks.Add(new Risks
                {
                    RiskName = nameRisks[randObj.Next(count_nameRisks_voc)],
                    RiskDescription = RiskDescription[randObj.Next(count_RiskDescription_voc)],
                    AverageProbability = averageProbability[randObj.Next(count_averageProbability_voc)],
                    TypeId = randObj.Next(1, 3)
                });
            }
            db.SaveChanges();

            string[] groupName = { "groupName1", "groupName2", "groupName3", "groupName4", "groupName5" };
            int count_groupName_voc = groupName.GetLength(0);
            string[] groupDescription = { "groupDescription1", "groupDescription2", "groupDescription3", "groupDescription4", "groupDescription5" };
            int count_groupDescription_voc = groupDescription.GetLength(0);
            
            for (int ID = 1; ID <= 1000; ID++)
            {
                
                db.ClientGroups.Add(new ClientGroups
                {
                    GroupName= groupName[randObj.Next(count_groupName_voc)],
                    GroupDescription = groupDescription[randObj.Next(count_groupDescription_voc)],
                });
            }
            db.SaveChanges();

        }
    }
}
