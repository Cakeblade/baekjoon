import sys

data = sys.stdin.readline().rstrip()
a = [-1]
b = ['a']

for i in range(98, 123):
    a.append(-1)
    b.append(chr(i))

for i in range(len(data)):
    for j in range(26):
        if b[j] == data[i]:
            if a[j] == -1:
                a[j] = i

print(*a)
