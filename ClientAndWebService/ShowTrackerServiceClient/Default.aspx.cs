using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    ShowTrackerServiceReference.ShowInfoServiceClient stsc = new ShowTrackerServiceReference.ShowInfoServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //methods for dropdown list
            FillVenueDropDown();
            FillArtistDropDown();
            FillShowDropDown();
            FillShowByVenueDropDown();
            FillShowByArtistDropDown();
        }
    }
    //venue dropdown
    protected void FillVenueDropDown()
    {
        string[] venues = stsc.GetVenues();
        VenueDropDownList.DataSource = venues;
        VenueDropDownList.DataBind();
    }
    //artist dropdown
    protected void FillArtistDropDown()
    {
        string[] artist = stsc.GetArtists();
        ArtistDropDownList.DataSource = artist;
        ArtistDropDownList.DataBind();
    }
    //show dropdown
    protected void FillShowDropDown()
    {
        string[] shows = stsc.GetShows();
        ShowDropDownList.DataSource = shows;
        ShowDropDownList.DataBind();
    }
    //Show By Artist Dropdown
    protected void FillShowByArtistDropDown()
    {
        string[] artist = stsc.GetArtists();
        ArtistByShowDropDownList.DataSource = artist;
        ArtistByShowDropDownList.DataBind();
    }
    //Show by Venue Dropdown
    protected void FillShowByVenueDropDown()
    {
        string[] venues = stsc.GetVenues();
        VenueByShowDropDownList.DataSource = venues;
        VenueByShowDropDownList.DataBind();
    }

    //Buttons for Shows by Venues and for Shows by Artist
    protected void VenueByShowButton_Click(object sender, EventArgs e)
    {
        string venue = VenueByShowDropDownList.SelectedItem.Text;
        ShowTrackerServiceReference.ShowInfo[] show = stsc.GetShowByVenue(venue);
        VenueByShowGridView.DataSource = show;
        VenueByShowGridView.DataBind();
    }
    
    protected void ArtistByShowButton_Click(object sender, EventArgs e)
    {
        string artist = ArtistByShowDropDownList.SelectedItem.Text;
        ShowTrackerServiceReference.ShowInfo[] show = stsc.GetShowByArtist(artist);
        ArtistByShowGridView.DataSource = show;
        ArtistByShowGridView.DataBind();
    }

}