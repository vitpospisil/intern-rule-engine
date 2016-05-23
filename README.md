# intern-rule-engine

## Create a simple rule engine for sailig competitions

- there are multiple competitors in a race
- there are multiple races  (2-16) in a single competition

### Race rules
- after each race competitors position is assigned in order they finished (1, 2, 3, ..) it can happen they finished at the same time (1, 1, 2, 3)!
- the points are assigned in the same order as position based on the pointing system, the simples point system is (1, 2, 3, 4, ...)
- if some of the competitors finished on the same position the points are splitted between them (position: 1, 1, 2; points: 1.5, 1.5, 3) 
- the rank is assigned based on points if some of the competitors has the same number of points, they have the same rank but the next rank is left out (points: 1.5, 1.5, 3, 4, rank: 1, 1, 3, 4)

### Competition rules
- the result of competition is simple a sum of race points for each competitor
- there can be specified that the _n_ worst races can be discarded
- there are special rules how to handle ties (when you have competitors on the same place in competition results)

## Task1
Calculate rank and points for a signle race (for all three data1/race1.csv, data1/race2.csv, data1/race3.csv)

## Notes
The application should be a simple console application no UI.
The code changes should be done on your fork (that means first you need to fork the repo and there do all the changes)
