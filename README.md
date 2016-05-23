# intern-rule-engine

## Create a simple rule engine for sailig competitions

- there are multiple competitors in a race
- there are multiple races  (2-16) in a single competition

### Race rules
- after each race competitors position is assigned in order they finished (1, 2, 3, ..) it can happen they finished at the same time (1, 1, 3, 4)!
- the points are assigned in the same order as position based on the pointing system, the simples point system is (1, 2, 3, 4, ...)

### Competition rules
- the result of competition is simple a sum of race points for each competitor
- there can be specified that the _n_ worst races can be discarded
- there are special rules how to handle ties (when you have competitors on the same place in competition results)

## 
