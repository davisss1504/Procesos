Feature: Final Average
	In know my final average
	As student
	I want to be told the sum of three notes

@mytag
Scenario Outline: Average three notes
	Given  first note is <note1>
	And second note is <note2>
	And  third note is <note3>
	When the notes are averaged
	Then average total <total>
	Examples: 
| note1 | note2| note3 | total |
| 6     | 6    | 7,5   | 6.5   |
| 5     | 5    | 8     | 6     |
| 9.3   | 9.6  | 9     | 27.9  |