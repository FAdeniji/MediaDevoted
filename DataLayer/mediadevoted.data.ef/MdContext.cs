using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace mediadevoted.data.ef
{
    public class MdContext : DbContext
    {
        private MdContext(DbContextOptions<MdContext> options) : base(options)
        {
        }
    }
}
