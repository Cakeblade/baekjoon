import sys

t1, t2, t3 = map(int, sys.stdin.readline().split())

club = int(sys.stdin.readline())

tmp = 0
clubScore = 0
maxScore = -1

for i in range(club):
    clubScore = 0
    for j in range(3):
        c1, c2, c3 = map(int, sys.stdin.readline().split())
        tmp = t1 * c1
        tmp = tmp + t2 * c2
        tmp = tmp + t3 * c3
        clubScore += tmp
    if maxScore < clubScore:
        maxScore = clubScore

print(maxScore)
