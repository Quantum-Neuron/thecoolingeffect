import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import Homepage from "./Views/Homepage"
import AboutVM from "./Views/AboutVM";
import About from "./Views/About";

const AboutWrapper: React.FC = () => {
  const aboutVM = new AboutVM();
  return <About viewModel={aboutVM} />;
}

const PageRoutes: React.FC = () => {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<Homepage />} />
        <Route path="/about" element={<AboutWrapper />} />
        <Route path="*" element={<Homepage />} />
      </Routes>
    </Router>
  );
};

export default PageRoutes;