namespace TrelloExportToObsidianKanbanBoard
{
    public class TrelloBoardSimplified
    {
        public List<TrelloListimplified> Lists { get; set; }
    }

    public class TrelloListimplified
    {
        public string Name { get; set; }
        public List<string> Tasks { get; set; }
    }

}
