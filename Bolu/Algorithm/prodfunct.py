def list_prodfunc(my_list):
    size = len(my_list)
    answer = [0]*size
    
    answer[0] = 1
    
    for i in range(1, size):
        answer[i] = my_list[i - 1] * answer[i - 1]

    
    R = 1;
    for i in reversed(range(size)):
        answer[i] = answer[i] * R
        R *= my_list[i]
        
    return answer
    
    
print(list_prodfunc([1,2,3,4]))
for i in reversed(range(4)):
    print(i)