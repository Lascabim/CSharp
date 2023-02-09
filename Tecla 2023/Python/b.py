n = int(input())

if n==0 or n==1:
    div=1
else:
    div=2
    for i in range(2,n//2+1):
        if n%i==0:
            div=3
            break
if div==2:
    print('1')
else:
    print('0')
