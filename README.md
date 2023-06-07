# TrelloExportToObsidianKanbanBoard

A simple script allowing migrating Trello boards > lists > cards to markdown files supported by [Kanban extension in Obsidian](https://github.com/mgmeyers/obsidian-kanban).

By all means, it's not perfect. A few issues I've noticed:
- it brings back some 'phantom' tasks back to live (most likely the deleted ones)
- it doesn't bring in empty lists
- it cocks up the order of tasks within cards

Nonetheless... It helped me and may also help you save some copy-paste labour, or provide a baseline for a more robust script if it proves useful.

## How to:

1. If you don't yet have it, install the [Kanban plugin in Obsidian](https://github.com/mgmeyers/obsidian-kanban)
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

## Result

Trello board:
![image](https://github.com/pflajszer/TrelloExportToObsidianKanbanBoard/assets/45766938/83acbec9-5d22-4045-85d4-7f2f5f528d3e)

Parsed Obsidian board:
![image](https://github.com/pflajszer/TrelloExportToObsidianKanbanBoard/assets/45766938/de75d7c9-273b-4f80-9621-033e0610cfc0)
