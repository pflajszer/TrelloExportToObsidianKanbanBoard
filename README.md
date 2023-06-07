# TrelloExportToObsidianKanbanBoard

A simple script allowing migrating Trello boards > lists > cards to markdown files supported by [Kanban extension in Obsidian](https://github.com/mgmeyers/obsidian-kanban).

## How to:

1. Log in to Trello
2. Go to your board
3. Menu > More > Print and Export > Export to JSON
4. Copy the JSON contents
5. Save the file locally as `.json`
6. Clone this repo locally
7. Provide `inputJsonPath` variable to point to your downloaded JSON file
8. Optionally, provide the path to where you'd like the output path to be
9. Press F5 / Run the script
10. Now copy your output `.md` file and paste it in your Obsidian directory in whichever folder you'd like it in.
