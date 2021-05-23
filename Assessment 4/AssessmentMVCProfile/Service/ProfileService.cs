using AssessmentMVCProfile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentMVCProfile.Service
{
    public class ProfileService : IProfileRepo<Profile>
    {
        private readonly ProfileContext _context;
        public ProfileService()
        { }
        public ProfileService(ProfileContext context)
        {
            _context = context;
        }
        public bool Register(Profile t)
        {
            try
            {
                _context.Profiles.Add(t);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }
    }
}
