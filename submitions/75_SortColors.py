class Solution:
    def sortColors(self, nums) -> None:
        for i in range(len(nums)-1):
            lowest = i
            for j in range(i+1, len(nums)):
                if nums[j] < nums[lowest]:
                    lowest = j
            nums[i], nums[lowest] = nums[lowest], nums[i]
