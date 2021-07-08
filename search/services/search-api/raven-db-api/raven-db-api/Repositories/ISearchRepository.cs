using Raven.Client.Documents;

public interface ISearchRepository
{
    void InitStore();
    string GetSearch();
}