# Issue tracker: GitHub

Issues and specs for this repo live in GitHub Issues. Use `gh` from this repo; it resolves `Insulinocytus/LEAntiFog` from the remote.

- Create: `gh issue create --title "..." --body "..."`
- Read: `gh issue view <number> --comments`; also fetch labels.
- List: `gh issue list --state open --json number,title,body,labels,comments`
- Comment: `gh issue comment <number> --body "..."`
- Label: `gh issue edit <number> --add-label "..."` or `--remove-label "..."`
- Close: `gh issue close <number> --comment "..."`

When a skill says to publish an issue or fetch a ticket, use this tracker. For blocking relationships, use GitHub's native issue dependencies when available; otherwise put `Blocked by: #<number>` in the issue body.

**PRs as a request surface: no.**
