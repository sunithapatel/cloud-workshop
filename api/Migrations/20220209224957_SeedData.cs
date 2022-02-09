using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResourcesApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Body", "Description", "EligibilityCriteria", "InternshipPeriod", "Name", "Stipend", "Url" },
                values: new object[,]
                {
                    { 1, "Google Summer of Code program is a program started by Google and has completed 16 years. It is a program that aims to promote open-source software development among university students. There are a few organizations and these organizations have mentors.", "You can work with famous organizations like, Debian, Fedora, GCC, FreeBSD, Git (Not GitHub), Gnome, OpenSUSE Arduino, and other more top names in Open Source community.", "none", 3, "Google Summer of Code", true, "https://summerofcode.withgoogle.com/" },
                    { 2, "If you want to intern at the Free Software Foundation and you know web development, systems, networking, software licensing you can consider the FSF internship program. It has pretty good projects over there and here you get to work with the organizations that sponsor the GNU Project.", "The oldest, mother of all organizations which started the free software movement. The Internship program runs thrice a year.", "none", 3, "Free Software Foundation (FSF)", false, "https://www.fsf.org/volunteer/internships" },
                    { 3, "X.Org Endless Vacation of Code (EVoC) is a Google Summer of Code (GSoC)-like project initiated in 2008 funded by the X.Org Foundation. It allows students to participate to X. Org-related projects during their vacation, at any time of the year.", "Project which develops, maintains, supports the free software stack for accelerated graphics for all graphics hardware.", "none", 4, "X.Org Endless Vacation of Code", true, "https://www.x.org/wiki/XorgEVoC/" },
                    { 4, "Redox is a general-purpose operating system written in pure Rust. The Redox OS Summer of Code is the primary use of donations to the Redox OS project. Here, the students who have already demonstrated a desire and ability to contribute to Redox OS get selected.", "Project to entice/enhance women participation in Rust, Clojure, JavaScript, PHP, Python, Ruby on Rails, Rails web framework etc.", "For Girls only", 3, "Redox OS Summer of Code (RGSOC)", true, "https://railsgirlssummerofcode.org/blog/2017-07-12-namaste-rgsoc-2017" },
                    { 5, "The Data Observation Network for Earth (DataONE) is a virtual organization dedicated to providing open, persistent, robust, and secure access to biodiversity and environmental data, supported by the U.S. National Science Foundation.", "A project to collect, understand earth observational data using a variety of sensors, testing and making cohesive sense out of the data collected.", "none", 4, "Data Observation Network for Earth (DataONE)", true, "https://old.dataone.org/internships" },
                    { 6, "Open Daylight Project‘s mission is to facilitate a community-led, industry-supported open source framework, including code and architecture, to accelerate and advance a common, robust Software-Defined Networking platform.", "FOSS Project which works to use and promote software-defined networking and network functions visualization.", "none", 3, "OpenDaylight", true, "http://archive15.opendaylight.org/community/summer-intern-program" },
                    { 7, " Open Mainframe Project Mentorship Program is the open-source program that is hosted by the Linux Foundation and aims to introduce everyone to the mainframe community and development environment on Linux.", "Open Mainframe Project also has its own open-source program and the mentees will be able to expand their knowledge on the mainframe technology. You’ll also help in contributing to open source projects which will make it easier for infrastructure applications to run on the mainframe.", "none", 3, "Open Mainframe Project Mentorship Program", false, "https://www.openmainframeproject.org/projects/mentorship-program" },
                    { 8, "Aims to help beginners get started with Open Source Development while encouraging diversity. Throughout the program, participants contribute to different projects under guidance of experienced mentors.", "Their mission is to impinge on every individual who has the zeal to learn more. Around the year we conduct several educational programs and offer internship opportunities to the youngsters so that they become industry-ready.", "none", 3, "GirlsScript Summer of Code", true, "https://gssoc.girlscript.tech/" },
                    { 9, "The Outreachy internship projects focus on programming, documentation, project marketing, etc. During the application process, you need to show some genuine eagerness that why you want to be an Outreachy intern and in turn, what you’re going to accomplish, and then how you plan to promote diversity and all sorts of things.", "Outreachy started in 2006, wrapped up, and started up again in 2010. I did share an interview with Maria Glukova which shared her experience. Twice a year it runs and has in excess of 30+ interns per year from 20+ projects including Debian, Redhat, OpenStack, and many others.", "Women, trans and cisgendered women", 3, "Outreachy", true, "https://www.gnome.org/outreachy/" },
                    { 10, "Google Season of Docs is a program by Google where technical writers and open source organizations come together and work on open source projects. They aim to raise awareness of open source, of docs, and of technical writing.", "Technical writers can spend three months working closely with an open-source community. Bring their technical writing expertise to the project’s documentation. Google uses Payoneer to pay a stipend to technical writers who have successfully completed their Season of Docs projects.", "Women, trans and cisgendered women", 3, "Google Season of Docs", false, "https://developers.google.com/season-of-docs" },
                    { 11, "The Season of KDE, hosted by the KDE community, is an outreach program for all individuals across the world. KDE is an international free software community that develops free and open-source software and you can contribute to KDE through the Season of KDE program. ", "Khan Academy is looking for talented software developers to create a free virtual classroom for the world. You can work on developing web solutions, data analysis developing classroom content, etc.", "none", null, "Season of KDE", true, "https://season.kde.org/" },
                    { 12, "A month-long celebration of open source software run by DigitalOcean. Here, you need to submit four or more quality pull requests. The main idea over here is that there’s no such thing as a selection criterion in this particular program. ", "You can contribute to participating projects on GitHub and even if you’re not able to make a large major contribution what you can get out of it is how to use Git and Github.", "none", 1, "Digital Ocean Hacktoberfest", true, "https://hacktoberfest.digitalocean.com/" }
                });

            migrationBuilder.InsertData(
                table: "ApplicationPeriods",
                columns: new[] { "Id", "Month", "ResourceId" },
                values: new object[,]
                {
                    { 1, "March", 1 },
                    { 2, "April", 1 },
                    { 3, "April", 2 },
                    { 4, "May", 2 },
                    { 5, "January", 3 },
                    { 6, "February", 3 },
                    { 7, "March", 3 },
                    { 8, "April", 3 },
                    { 9, "May", 3 },
                    { 10, "June", 3 },
                    { 11, "July", 3 },
                    { 12, "August", 3 },
                    { 13, "September", 3 },
                    { 14, "October", 3 },
                    { 15, "November", 3 },
                    { 16, "December", 3 },
                    { 17, "February", 4 },
                    { 18, "March", 4 },
                    { 19, "April", 4 },
                    { 20, "February", 5 },
                    { 21, "March", 5 },
                    { 22, "January", 6 },
                    { 23, "February", 6 },
                    { 24, "March", 6 },
                    { 25, "February", 7 },
                    { 26, "March", 7 },
                    { 27, "April", 7 },
                    { 28, "May", 7 },
                    { 29, "June", 7 },
                    { 30, "July", 7 },
                    { 31, "August", 7 },
                    { 32, "September", 7 },
                    { 33, "January", 8 },
                    { 34, "February", 8 },
                    { 35, "February", 9 },
                    { 36, "March", 9 },
                    { 37, "April", 9 },
                    { 38, "June", 10 },
                    { 39, "July", 10 },
                    { 40, "October", 12 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name", "ResourceId" },
                values: new object[,]
                {
                    { 1, "Remote", 1 },
                    { 2, "Remote", 2 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name", "ResourceId" },
                values: new object[,]
                {
                    { 3, "Boston, US", 2 },
                    { 4, "Remote", 3 },
                    { 5, "Remote", 4 },
                    { 6, "United States", 5 },
                    { 7, "Remote", 6 },
                    { 8, "Remote", 7 },
                    { 9, "Remote", 8 },
                    { 10, "Remote", 9 },
                    { 11, "Remote", 10 },
                    { 12, "Remote", 11 },
                    { 13, "Remote", 12 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ApplicationPeriods",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
