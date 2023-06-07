using Newtonsoft.Json;
using TrelloExportToObsidianKanbanBoard;

var inputJsonPath = "../../../board.json";
var outputFilePath = "../../../kanban.md";

var json = File.ReadAllText(inputJsonPath);

var board = JsonConvert.DeserializeObject<TrelloBoard>(json);

var simplifiedBoard = BoardParser.Build(board);

string markdownContent = BoardParser.GenerateMarkdown(simplifiedBoard);

File.WriteAllText(outputFilePath, markdownContent);