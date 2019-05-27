import React, { useState } from "react";

function Counter() {
  const [count, setCount] = useState(0);

  return (
    <div>
      <h3>You clicked {count} times</h3>
      <button className="btn btn-primary" onClick={() => setCount(count + 1)}>
        +
      </button>
      <button className="btn btn-success" onClick={() => setCount(count - 1)}>
        -
      </button>
    </div>
  );
}

export default Counter;
