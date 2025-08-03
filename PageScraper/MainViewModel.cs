using CommunityToolkit.Mvvm.Input;
using PageScraper.Basics;

namespace PageScraper;

public class MainViewModel : ViewModelBase
{
    private string websiteUrl;
    private bool scrapeImages;
    private bool scrapeLinks;

    public RelayCommand StartScrapingCommand { get; }

    public MainViewModel()
    {
        StartScrapingCommand = new RelayCommand(StartScraping);
    }

    private async void StartScraping()
    {
        // ToDo: Implement logic for scraping
    }

    public string WebsiteUrl
    {
        get => websiteUrl;
        set
        {
            if (websiteUrl != value)
            {
                websiteUrl = value;
                OnPropertyChanged();
            }
        }
    }

    public bool ScrapeImages
    {
        get => scrapeImages;
        set
        {
            if (scrapeImages != value)
            {
                scrapeImages = value;
                OnPropertyChanged();
            }
        }
    }
    
    public bool ScrapeLinks
    {
        get => scrapeLinks;
        set
        {
            if (scrapeLinks != value)
            {
                scrapeLinks = value;
                OnPropertyChanged();
            }
        }
    }
}