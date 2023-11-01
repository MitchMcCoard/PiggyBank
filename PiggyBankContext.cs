
﻿using Microsoft.EntityFrameworkCore;

namespace PiggyBank
{
    public class PiggyBankContext : DbContext
    {

        public PiggyBankContext(DbContextOptions<PiggyBankContext> options)
            : base(options) { }

        //Should be a dbset, not a property
        public float CurrentSavings { get; set; }
       
    }

    
}
