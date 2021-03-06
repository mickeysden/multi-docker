import React, { useEffect, useState } from 'react';
import axios from 'axios';
import SubApp from './SubApp';

export default function App() {
  const [data, setData] = useState([]);

  useEffect(() => {
    axios
      .get("http://localhost:5001/api/values")
      .then(result => setData(result.data));
  }, []);

  return (
    <div>
      <p>Hello Values!</p>
      <ul>
        {data.map(item => (
          <li key={item.name}>
            {item.name}: {item.value}
          </li>
        ))}
      </ul>
      <hr />
      <SubApp />
    </div>
  );
}