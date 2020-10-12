k, n = map(int, input().split())
  
t = [0]*301
  
def get(n):
    count = 0
    for i in range(1,min(k+1,n+1)):
        if i==n:
            count += 1
        else:
            if t[n-i]==0:
                t[n-i] = get(n-i)
            count += t[n-i]
    return count
  
print(get(n))