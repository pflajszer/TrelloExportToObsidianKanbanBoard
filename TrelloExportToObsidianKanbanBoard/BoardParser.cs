namespace TrelloExportToObsidianKanbanBoard
{
    public static class BoardParser
    {
        public static TrelloBoardSimplified Build(TrelloBoard board)
        {
            var result = new TrelloBoardSimplified();
            result.Lists = new List<TrelloListimplified>();

            var cards = board.Actions.Where(x => x.Data?.Card != null && x.Data?.List != null).Select(x => (x.Data?.Card.Name, x.Data.List?.Name));

            foreach (var item in cards)
            {
                var list = result.Lists.FirstOrDefault(x => x.Name == item.Item2);
                if (list == null)
                {
                    list = new TrelloListimplified();
                    list.Name = item.Item2;
                    list.Tasks = new List<string>();
                    result.Lists.Add(list);
                }
                var task = list.Tasks.FirstOrDefault(x => x == item.Item1);
                if (task == null)
                    list.Tasks.Add(item.Item1);
            }

            return result;
        }

        public static string GenerateMarkdown(TrelloBoardSimplified board)
        {
            var markdown = new List<string>();

            // Add front matter
            markdown.Add("---");
            markdown.Add("kanban-plugin: basic");
            markdown.Add("---");
            markdown.Add("");

            // Generate markdown for each list and tasks
            foreach (var list in board.Lists)
            {
                markdown.Add($"## {list.Name}");
                markdown.Add("");

                foreach (var task in list.Tasks)
                {
                    markdown.Add($"- [ ] {task}");
                }

                markdown.Add("");
            }

            // Add kanban settings
            markdown.Add("%% kanban:settings");
            markdown.Add("{\"kanban-plugin\":\"basic\"}");
            markdown.Add("%%");

            // Combine lines into a single string
            string markdownContent = string.Join(Environment.NewLine, markdown);

            return markdownContent;
        }
    }

}
