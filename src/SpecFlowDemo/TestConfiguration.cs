using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace SpecFlowDemo
{
    public static class TestConfiguration
    {
        public static GitHubUser GitHubUser = new GitHubUser()
        {
            Username = "SpecFlowDemo",
            Email = "SpecFlowDemo@sharklasers.com",
            Password = "SpecFlowDemo@sharklasers.com"
        };
    }
}
