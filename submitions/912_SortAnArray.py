class Solution:
    def partition(self, arr, left, right):
        pivot = arr[right]
        i=left -1
        for j in range(left, right):
            if arr[j] < pivot:
                i += 1
                arr[i], arr[j] = arr[j], arr[i]
        arr[i+1], arr[right] = arr[right], arr[i+1]
        return i+1
    def quicksort(self, arr, left, right):
        if left < right:
            pivot = self.partition(arr, left, right)
            self.quicksort(arr, left, pivot-1)
            self.quicksort(arr, pivot+1, right)
    def sortArray(self, nums):
        self.quicksort(nums, 0, len(nums)-1)
        return nums