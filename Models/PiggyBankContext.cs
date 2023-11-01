
﻿using Microsoft.EntityFrameworkCore;

namespace PiggyBank.Models
{
    public class PiggyBankContext : DbContext
    {

        public PiggyBankContext(DbContextOptions<PiggyBankContext> options)
            : base(options) { }

        //Should be a dbset, not a property
        public virtual DbSet<SavingsGoal> SavingsGoals {get; set;}
       
    }

    
}
