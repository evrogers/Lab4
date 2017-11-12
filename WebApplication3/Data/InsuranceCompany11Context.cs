using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication3.Data
{
    public partial class InsuranceCompany11Context : DbContext
    {
        public InsuranceCompany11Context(DbContextOptions<InsuranceCompany11Context> options) : base(options)
        {
        }

        public virtual DbSet<ClientGroups> ClientGroups { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Policys> Policys { get; set; }
        public virtual DbSet<PolicyTypes> PolicyTypes { get; set; }
        public virtual DbSet<Risks> Risks { get; set; }
        public virtual DbSet<Staffs> Staffs { get; set; }

    }
}
