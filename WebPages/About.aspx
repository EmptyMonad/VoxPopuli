<%@ Page Title="" Language="C#" MasterPageFile="~/WebPages/RepMaster.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="VoxPopuli.WebPages.About" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<!--
	Tessellate by HTML5 UP
	html5up.net | @ajlkn
	Free for personal and commercial use under the CCA 3.0 license (html5up.net/license)
-->

		<title>About Vox Populi</title>
		<meta charset="utf-8" />
		<meta name="viewport" content="width=device-width, initial-scale=1, user-scalable=no" />
		<link rel="stylesheet" href="../CSS/About.css" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


		<!-- Header -->
			<section id="header" class="dark">
				<header>
					<h1>About Vox Populi</h1>
					<p>A Visualization of Texas' Political Map</p>
				</header>
				<footer>
					<a href="#first" class="button scrolly">What is Vox Populi?</a>
				</footer>
			</section>

		<!-- First -->
			<section id="first" class="main">
				<header>
					<div class="container">
						<h2>What is Vox Populi?</h2>
						<p>The goal of Vox Populi is to serve as a visual representation of how popular the congressional representatives of Texas are, based strictly on what they have voted on recent bills, rather than biased 
							news articles or party lines. Users are able to view recent bills voted on each representative, decide whether they approve or disapprove of the representative’s vote, and vote accordingly. These votes are
							then factored into an overall score for each representative, and their respective district is painted accordingly based on the overall score. Right now, our scale is earth-toned with lighter shades of green
							for increasing popularity, and darker shades of brown for decreasing popularity. This is version 1.0 of Vox Populi, so expect many improvements and new features in the near future.</p>
					</div>
				</header>
				<section id="header" class="dark">
					<header>
						<h1>Get Started</h1>
					</header>
					<footer>
						<a href="#second" class="button scrolly">Proceed to Step 1</a>
					</footer>
				</section>
					</div>
				</div>
			</section>

		<!-- Second -->
			<section id="second" class="main">
				<header>
					<div class="container">
						<h2>Step 1 - Get Started</h2>
						<p>
							On the homepage, you will see 4 icons on the top left of the website located on the sidebar. The icon that is second from the top is used for logins, and the icon third from the top is used for new user registrations.
							 Select the register button if you are a new user and register an account. Otherwise, login to your account to be able to vote on representative actions.	
						</p>
					</div>
				</header>
				<section id="header" class="dark">
					<header>
						<h1>Find Your District</h1>
					</header>
					<footer>
						<a href="#third" class="button scrolly">Proceed to Step 2</a>
					</footer>
				</section>
			</section>

		<!-- Third -->
			<section id="third" class="main">
				<header>
					<div class="container">
						<h2>Step 2 - Find Your District</h2>
						<p>Click on the person icon in the top right of the sidebar. This will pull out the representative information tab. Then, hover over the Texas districts. 
							This will give you some quick information on the representative and the district number. Or you can simply zoom in on the map to find out which district specific cities or locations are in.</p>
					</div>
				</header>
				<section id="header" class="dark">
					<header>
						<h1>View Represenative Actions</h1>
					</header>
					<footer>
						<a href="#fourth" class="button scrolly">Proceed to Step 3</a>
					</footer>
				</section>
			</section>
			<!-- Fourth -->
			<section id="fourth" class="main">
				<header>
					<div class="container">
						<h2>Step 3 - View Represenative Actions</h2>
						<p>When a district is clicked, you are redirected to the that representatives web page. There you will see 20 recent bills and what that representative voted on each bill. Obviously, you are
							 unlikely to know if you support a bill without reading it. Click on the bill icon for each respective bill, and you will be redirected to the congress.gov webpage for the bill, and you can 
							 read a plethora of information on the legislation, including the raw text of the bill.</p>
					</div>
				</header>
				<section id="header" class="dark">
					<header>
						<h1>Cast Your Vote</h1>
					</header>
					<footer>
						<a href="#fifth" class="button scrolly">Proceed to Step 4</a>
					</footer>
				</section>
			</section>
				<!-- Fourth -->
				<section id="fifth" class="main">
					<header>
						<div class="container">
							<h2>Step 4 - Cast Your Vote</h2>
							<p>Navigate back to the representative webpage. Rather than voting on the bill itself, it is important to keep in mind you are voting for the REPRESENTATIVE’S vote on the bill. 
								For instance, if you decide you support this bill, but the representative voted NO, you will hit the downvote button. However, if you support a bill and they voted YES on that 
								bill, you will hit the upvote button.</p>
						</div>
					</header>
					<section id="header" class="dark">
						<header>
							<h1>Get Started</h1>
						</header>
						<footer>
							<a href="MainPage.aspx" class="button scrolly">Return To Home Page</a>
						</footer>
					</section>
				</section>

		<!-- Scripts -->
			<script src="../JavaScript/AboutJs/jquery.min.js"></script>
			<script src="../JavaScript/AboutJs/jquery.scrolly.min.js"></script>
			<script src="../JavaScript/AboutJs/browser.min.js"></script>
			<script src="../JavaScript/AboutJs/breakpoints.min.js"></script>
			<script src="../JavaScript/AboutJs/util.js"></script>
			<script src="../JavaScript/AboutJs/main.js"></script>

	</body>
</html>
</asp:Content>
