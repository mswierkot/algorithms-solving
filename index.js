/*
  Input: nums = [2,7,11,15], target = 9
  Output: [0,1]
  Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
*/

function findAllIndexes(arr, element) {
  return arr.reduce(function (a, e, i) {
    if (e === element) a.push(i);
    return a;
  }, []);
}

var twoSum = function (nums, target) {
  const map = new Map();

  for (let num of nums) {
    map.set(num, findAllIndexes(nums, num));
  }

  let indeces = [];

  for (let num of nums) {
    indeces = [nums.indexOf(num)];

    let desiredNum = target - num;
    if (map.get(desiredNum) !== undefined) {
      let desiredNumIndeces = map.get(desiredNum);
      if (desiredNumIndeces.length >= 2) {
        return desiredNumIndeces;
      }
      if (indeces[0] != desiredNumIndeces[0]) {
        let a = indeces[0];
        let b = desiredNumIndeces[0];
        return [a, b];
      }
    }
  }
};

function main() {
  console.log(twoSum([1, 2, 2, 2, 2, 2, 2, 1], 2));
  console.log(twoSum([3, 2, 4], 6));
  console.log(twoSum([1, 2, 3, 4, 5], 9));
  console.log(twoSum([3, 3], 6));
}

main();
