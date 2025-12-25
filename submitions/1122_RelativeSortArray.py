class Solution:
    def relativeSortArray(self, arr1, arr2):
        output = []
        complement = []
        for i in range(len(arr2)):
            for j in range(len(arr1)):
                if arr1[j] == arr2[i]:
                    output.append(arr1[j])
        
        for i in range(len(arr1)):
            if arr1[i] not in output:
                complement.append(arr1[i])
        complement.sort()

        output.extend(complement)
        return output
