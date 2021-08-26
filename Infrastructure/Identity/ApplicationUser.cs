using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tournamenttracker.template.Infrastructure.Identity
{
    public class ApplicationUser : IdentityUser
    {
    }
    public static class Roles
    {
        /// <summary>
        /// Oversees leagues within system
        /// </summary>
        public static string AppChamp = "AppChamp";
        /// <summary>
        /// Director of a league
        /// </summary>
        public static string Director = "Director";
        /// <summary>
        /// Coordinator of a Tournament
        /// </summary>
        public static string Coordinator = "Coordinator";
        /// <summary>
        /// Player a part of a Team
        /// </summary>
        public static string Player = "Player";
        /// <summary>
        /// User with no home
        /// </summary>
        public static string User = "User";
    }
}
