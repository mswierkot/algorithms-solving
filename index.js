function findLongestUniqueCharSubstring(word) {
  let set = new Set();
  for (let i = 0; i < word.length; i++) {
    if (set.has(word[i])) {
      i = word.length;
    } else {
      set.add(word[i]);
    }
  }

  let result = '';
  for (let letter of set.values()) {
    result += letter;
  }
  return result;
}

function main() {
  let word = 'pwwkew';
  console.log(findLongestUniqueCharSubstring(word).length);
}

main();
